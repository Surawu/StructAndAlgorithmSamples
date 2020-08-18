// 2.1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "InkListExer.h"

int main()
{
	InkListExer* list = new InkListExer(100);
	list->Append(1);
	list->Append(2);
	list->Append(3);
	list->Append(4);
	list->Append(5);
	list->Append(1);
	list->Append(1);

	ListAddress* la = list->Find(1);

	std::cout << "Hello World!\n";
}

