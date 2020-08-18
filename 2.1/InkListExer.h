#include <iostream>

struct LinkExer
{
	int data;
	LinkExer* next;
};

struct ListAddress
{
	LinkExer* address;
	ListAddress* qlink;
};

class InkListExer
{
public:
	InkListExer(int size);
	~InkListExer();

public:
	ListAddress* Find(int a);
	bool Append(int value);
	ListAddress* GetAddress();

private:
	LinkExer* head;
	LinkExer* tail;
	ListAddress* la;
	int curLength;
};

InkListExer::InkListExer(int size)
{
	head = tail = new LinkExer();
}

InkListExer::~InkListExer()
{
}

inline ListAddress* InkListExer::Find(int a)
{
	if (curLength < 1)
	{
		return nullptr;
	}
	LinkExer* node = head;
	while (node != nullptr)
	{
		if (node->data == a)
		{
			la->qlink = new ListAddress();
			la->address = node;
			la = la->qlink;
			la->qlink = nullptr;
		}
		node = node->next;
	}

	return la;
}

inline bool InkListExer::Append(int value)
{
	LinkExer* node = new LinkExer();
	node->data = value;
	node->next = nullptr;
	tail->next = node;
	tail = node;

	curLength++;
	return true;
}

inline ListAddress* InkListExer::GetAddress()
{
	return la;
}
