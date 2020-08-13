// LinkedList.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "InkList.h"
#include "DInkList.h"

int main()
{
	{
		InkList<int>* list = new InkList<int>(100);
		list->Append(5);
		list->Append(6);
		list->Append(7);
		list->Append(8);
		list->Delete(0);
		int p;
		list->GetPos(p, 8);
		int v;
		list->GetValue(2, v);
		list->Insert(0, 1);
		int count = list->Length();
		list->Clear();
	}

	{
		DInkList<int>* list = new DInkList<int>(100);
		list->Append(4);
		list->Append(5);
		list->Append(6);
	}
	std::cout << "Hello World!\n";
}
