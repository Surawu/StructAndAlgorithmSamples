#include <iostream>

struct LinkExer
{
	int data;
	LinkExer* next; // 指向后继结点的指针
};

struct ListAddress
{
	LinkExer* address;
	ListAddress* qlink; // 新链表的指针变量
};

class InkListExer
{
public:
	InkListExer(int size);
	~InkListExer();

public:
	ListAddress* Find(int a);
	bool Append(int value);
	int LACount();

private:
	LinkExer* head;
	LinkExer* p; // 原链表的指针变量
	ListAddress* laHead; // 新链表的头结点
	int curLength;
	int laCount;
};

InkListExer::InkListExer(int size)
{
	head = p = new LinkExer();
	laHead = new ListAddress();
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
	ListAddress* q = laHead; // q 为新链表的指针变量
	p = head; // 指向头指针
	while (p != nullptr)
	{
		if (p->data == a)
		{
			ListAddress* laNode = new ListAddress();
			laNode->address = p;
			laNode->qlink = nullptr;
			q->qlink = laNode;
			q = q->qlink;
			laCount++;
		}
		p = p->next;
	}

	return laHead;
}

inline bool InkListExer::Append(int value)
{
	LinkExer* node = new LinkExer();
	node->data = value;
	node->next = nullptr;
	p->next = node;
	p = node;

	curLength++;
	return true;
}

inline int InkListExer::LACount()
{
	return laCount;
}
