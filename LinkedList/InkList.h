#include "Link.h"
#include <iostream>

template <typename T> class InkList
{
private:
	Link<T>* head, * tail;
	int curLength;
	Link<T>* setPos(const int i) // 时间复杂度 O(n)
	{
		int count = 0;
		if (i == -1)
		{
			return head;
		}

		Link<T>* p = new Link<T>(head->next);
		while (p != nullptr && count < i)
		{
			p = p->next;
			count++;
		}
		return p;
	}

public:
	InkList(const int s)
	{
		head = tail = new Link<T>(nullptr);
	}
	~InkList()
	{
		Link<T>* tmp;
		while (head != nullptr)
		{
			tmp = head;
			head = head->next;
			delete tmp;
		}
	}

	bool IsEmpty()
	{
		if (head->next == nullptr)
		{
			return true;
		}

		return false;
	}

	void Clear()
	{
		head = tail = new Link<T>;
	}

	int Length()
	{
		return curLength;
	}

	bool Append(T value)
	{
		Link<T>* q = new Link<T>(value, tail->next);
		tail->next = q;
		tail = q;

		curLength++;
		return true;
	}

	bool Insert(int i, T value)
	{
		Link<T>* p, * q;
		if ((p = setPos(i - 1)) == NULL)
		{
			std::cout << "非法插入地點" << std::endl;
		}
		q = new Link<T>(value, p->next);
		p->next = q;
		if (p == tail)
		{
			tail = q;
		}

		curLength++;
		return true;
	}

	bool Delete(int i)
	{
		Link<T>* p, * q;
		if ((p = setPos(i - 1)) == nullptr || p == tail)
		{
			std::cout << "invalid delete point" << std::endl;
			return false;
		}

		q = p->next;
		if (q == tail)
		{
			tail = p;
			p->next = nullptr;
			delete q;
		}
		else if (q != nullptr)
		{
			p->next = q->next;
			delete q;
		}
		curLength--;
		return true;
	}

	bool GetValue(int p, T& value);
	bool GetPos(int& p, T value);
};

