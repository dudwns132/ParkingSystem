#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <Winsock.h>
#include <iostream>
#include <vector>
#include <sstream>
#include <mysql.h>

#pragma comment (lib, "libmysql.lib")
#pragma comment (lib, "ws2_32.lib")

#define DB_HOST "127.0.0.1"
#define DB_USER "root"
#define DB_PASS "root"
#define DB_NAME "parking_project"

using namespace std;

class Client {
private:
	int clientID;
	SOCKET clientSocket;

public:
	string p_code;
	string c_code;
	string car_num;

	Client(int clientID, SOCKET clientSocket) {
		this->clientID = clientID;
		this->clientSocket = clientSocket;
		this->p_code = "";
		this->c_code =  "";
		this->car_num = "";
	}
	int getClientID() {
		return clientID;
	}
	SOCKET getClientSocket() {
		return clientSocket;
	}
};

SOCKET serverSocket;
vector<Client> connections;
WSAData wsaData;
SOCKADDR_IN serverAddress;

int nextID=0;

vector<string> getTokens(string input, char delimiter) {
	vector<string> tokens;
	istringstream f(input);
	string s;
	while (getline(f, s, delimiter)) {
		tokens.push_back(s);
	}
	return tokens;
}


void ServerThread(Client* client) {
	MYSQL* connection = NULL, conn;
	MYSQL_RES* sql_result;
	MYSQL_ROW sql_row;
	int query_stat;

	mysql_init(&conn);
	connection = mysql_real_connect(&conn, DB_HOST, DB_USER, DB_PASS, DB_NAME, 3306, (char*)NULL, 0);

	const char* query = "SELECT user_id FROM parking_project.user WHERE user_id='admin'";
	
	const char* update;
	if (connection == NULL)
	{
		fprintf(stderr, "Mysql connection error : %s", mysql_error(&conn));
		return;
	}

	

	//sql_result = mysql_store_result(connection);
	//while ((sql_row = mysql_fetch_row(sql_result)) != NULL)
	//{
	//	printf("%s\n", sql_row[0]);
	//}
	//mysql_free_result(sql_result);

	char* sent = new char[256];
	char* received = new char[256];
	int size = 0;
	while (true) {
		ZeroMemory(received, 256);
		int length = recv(client->getClientSocket(), received, 256, 0);
		if(length > 0){
			received[length] = NULL;

			char* token = strtok(received, "/");
			int i = 0;
			while (token != NULL) {
				switch (i++) {
				case 0:
					client->p_code = token; break;
				case 1:
					client->c_code = token; break;
				case 2:
					client->car_num = token; break;
				}
				token = strtok(NULL, "/");
			}

			string temp = "UPDATE `parking_project`.`camera` SET `car_num` = '" + client->car_num +"' WHERE";
			temp = temp + "(`p_code` = '" + client->p_code + "') and (`c_code` = '" + client->c_code + "');";
			update = temp.c_str();
			query_stat = mysql_query(connection, update);
			if (query_stat != 0)
			{
				fprintf(stderr, "Mysql query error : %s", mysql_error(&conn));
				return;
			}

			cout << "p_code:" + client->p_code + ", c_code:" + client->c_code + ", car_num:" + client->car_num << '\n';
			//cout << "[클라이언트 메시지]: " << received << '\n';
			//cout << "[메시지 전송]: " << received << '\n';
			send(client->getClientSocket(), received, 256, 0);
			//string sql = "UPDATE parking_project.camera SET car_num = " + car_num + " WHERE p_code = 1000 AND c_code = 1001;";
		}
		else {
			delete client;
			mysql_close(connection);
			break;

		}

	}
}


int main() {
	WSAStartup(MAKEWORD(2, 2), &wsaData);
	serverSocket = socket(AF_INET, SOCK_STREAM, NULL);

	serverAddress.sin_addr.s_addr = htonl(INADDR_ANY);
	//serverAddress.sin_addr.s_addr = inet_addr("118.39.171.111");
	serverAddress.sin_port = htons(9999);
	serverAddress.sin_family = AF_INET;

	cout << "[ C++ Server 가동 ]" << endl;
	printf("MySQL client version: %s\n", mysql_get_client_info());
	bind(serverSocket, (SOCKADDR*)&serverAddress, sizeof(serverAddress));
	listen(serverSocket, 10);

	int addressLength = sizeof(serverAddress);

	while (true) {
		SOCKET clientSocket = socket(AF_INET, SOCK_STREAM, NULL);
		SOCKADDR_IN clientaddr;
		addressLength = sizeof(clientaddr);
		if (clientSocket = accept(serverSocket, (SOCKADDR*)&clientaddr, &addressLength)) {
			Client* client = new Client(nextID++, clientSocket);
			cout << "[ 카메라 연동 ]" << endl;
			CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)ServerThread, (LPVOID)client, NULL, NULL);
			connections.push_back(*client);
		}
		Sleep(100);
	}
}