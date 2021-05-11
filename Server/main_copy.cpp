#include<iostream>
#include<string>
#include<WinSock2.h>

using namespace std;

void ShowErrorMessage(string message) {
	cout << "[오류 발생] : " << message << '\n';
	system("pause");
	exit(1);
}

int main() {
	WSADATA wsaDada;
	SOCKET serverSocket, clientSocket;
	SOCKADDR_IN serverAddress, clientAddress;

	int serverPort = 9876;
	char received[256];
	if (WSAStartup(MAKEWORD(2, 2), &wsaDada) != 0) // ws2를 사용하기위한 Winsock 초기화
		ShowErrorMessage("WSAStartup()");

	serverSocket = socket(PF_INET, SOCK_STREAM, 0); // TCP 소켓 생성

	if(serverSocket == INVALID_SOCKET)
		ShowErrorMessage("socket()");

	memset(&serverAddress, 0, sizeof(serverAddress)); // serverAddress를 0으로 초기화
	serverAddress.sin_family = AF_INET;
	serverAddress.sin_addr.s_addr = htonl(INADDR_ANY); // 4바이트 정수를 네트워크 바이트 형식으로
	serverAddress.sin_port = htons(serverPort); // 2바이트 정수를  네트워크 바이트 형식으로

	if (bind(serverSocket, (SOCKADDR*)&serverAddress, sizeof(serverAddress)) == SOCKET_ERROR)
		ShowErrorMessage("bind()");
	cout << "[현재 상태] bind()\n";

	if(listen(serverSocket, 5) == SOCKET_ERROR)
		ShowErrorMessage("listen()");
	cout << "[현재 상태] listen()\n";

	int sizeClientAddress = sizeof(clientAddress);
	clientSocket = accept(serverSocket, (SOCKADDR*)&clientAddress, &sizeClientAddress);
	cout << "[현재 상태] accept()\n";

	if(clientSocket == INVALID_SOCKET)
		ShowErrorMessage("listen()");

	while (true) {
		int length = recv(clientSocket, received, sizeof(received), 0);
		received[length] = NULL;
		cout << "[클라이언트 메시지]: " << received << '\n';
		cout << "[메시지 전송]: " << received << '\n';
		if (strcmp(received, "[exit]") == 0){
			send(clientSocket, received, sizeof(received) - 1, 0);
			cout << "[서버종료]\n";
			break;
		}
		send(clientSocket, received, sizeof(received) - 1, 0);
	}

	closesocket(clientSocket);
	closesocket(serverSocket);
	WSACleanup();
	system("pause");
	return 0;
}