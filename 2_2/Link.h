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
	p = head; // ָ��ͷָ��
	int falg = 0;
	while (p->next != nullptr) // δ������β��
	{
		if (p->next->data == nodeData)
		{
			LinkNode* newNode = new LinkNode();
			newNode->data = value;
			newNode->next = p->next;
			p->next = newNode;
			p = p->next; // �ղ����Ԫ������
			falg++;
			length++;
		}
		p = p->next;
	}
	if (falg == 0)
	{
		std::cout << "������ָ��Ԫ��" << std::endl;
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
