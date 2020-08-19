#include <iostream>

struct LinkNode
{
	double data;
	LinkNode* next;
};

class Link
{
public:
	Link();
	~Link();
	void Insert(double nodeData, double value);
	bool Append(double value);

private:
	LinkNode* head;
	LinkNode* p;
	int length;
};

Link::Link()
{
	head = p = new LinkNode();
}

Link::~Link()
{
}

inline void Link::Insert(double nodeData, double value)
{
	p = head; // 指向头指针
	int falg = 0;
	while (p->next != nullptr) // 未到链表尾部
	{
		if (p->next->data == nodeData)
		{
			LinkNode* newNode = new LinkNode();
			newNode->data = value;
			newNode->next = p->next;
			p->next = newNode;
			p = p->next; // 刚插入的元素跳过
			falg++;
			length++;
		}
		p = p->next;
	}
	if (falg == 0)
	{
		std::cout << "不存在指定元素" << std::endl;
	}
}

inline bool Link::Append(double value)
{
	LinkNode* newNode = new LinkNode();
	newNode->data = value;
	newNode->next = nullptr;
	p->next = newNode;
	p = p->next;
	length++;

	return true;
}
