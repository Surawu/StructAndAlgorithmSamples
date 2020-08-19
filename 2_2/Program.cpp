#include "Link.h"
#include <iostream>

int main()
{
	Link* list = new Link();
	list->Append(1);
	list->Append(2);
	list->Append(3);
	list->Append(4);
	list->Append(1);

	list->Insert(1, 100);
}