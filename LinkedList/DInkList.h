#include "DLink.h"
#include <iostream>

template <typename T> class DInkList
{
private:
	DLink<T>* head, * tail;
	int curLength;
	DLink<T>* setPos(const int i) //find the number i node,  ±º‰∏¥‘”∂» O(n)
	{
		int count;
		if (i == -1)
		{
			return head;
		}

		DLink<T>* node = head->next;
		while (node != nullptr && count < i)
		{
			node = node->next;
			count++;
		}

		return node;
	}

public:
	DInkList(const int s)
	{
		head = tail = new DLink<T>(nullptr, nullptr);
	}
	~DInkList()
	{
		DLink<T>* tmp;
		while (head != nullptr)
		{
			tmp = head;
			head = head->next;
			delete tmp;
		}
	}

	bool IsEmpty();

	void Clear();

	int Length();

	bool Append(T value);

	bool Insert(int i, T value);

	bool Delete(int i);

	bool GetValue(int p, T& value);
	bool GetPos(int& p, T value);
};

template<typename T>
inline bool DInkList<T>::IsEmpty()
{
	return curLength;
}

template<typename T>
inline void DInkList<T>::Clear()
{
	head = tail = new DLink<T>(nullptr, nullptr);
	curLength = 0;
}

template<typename T>
inline int DInkList<T>::Length()
{
	return curLength;
}

template<typename T>
inline bool DInkList<T>::Append(T value)
{
	DLink<T>* p = tail;
	DLink<T>* node = new DLink<T>(value, tail, tail->next);
	tail->next = node;
	tail = node;
	return true;
}
