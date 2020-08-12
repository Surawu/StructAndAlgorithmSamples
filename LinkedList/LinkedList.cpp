// LinkedList.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "InkList.h"

int main()
{
	InkList<int>* inkList = new InkList<int>(100);
	inkList->Append(5);
	inkList->Append(7);
	inkList->Append(8);
	inkList->Append(50);
	std::cout << "Hello World!\n";
}
