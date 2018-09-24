#include <iostream>
#include <string>

using namespace std;

string compress(string str);

int main() {
	system("chcp 1251 & cls");
	string someStr;

	cout << "Исходн. строка: ";
	getline(cin, someStr);

	cout << "Размер: " << someStr.length() << endl;
	someStr = compress(someStr);
	cout << "Формат. строка: " << someStr << "\nРазмер: " << someStr.length() << endl;

	getchar();
	return 0;
}

string compress(string str) {
	for (int i = 0; i < str.length(); i++) {
		if (str[i] == ' ') {
			str.erase(i, 1);
		}
	}
	return str;
}