#include "DLink.h"
#include <iostream>

template <typename T> class DInkList
{
private:
	DLink<T>* head, * tail;
	int curLength;
	DLink<T>* setPos(const int i) //find the number i node,  ±º‰∏¥‘”∂» O(n)
	{
		int count = 0;
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
		curLength = 0;
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
	curLength++;
	return true;
}

template<typename T>
inline bool DInkList<T>::Insert(int i, T value)
{
	if (i > curLength || i < -1)
	{
		std::cout << "invalid position" << std::endl;
		return false;
	}

	DLink<T>* pre = setPos(i - 1);
	DLink<T>* newNode = new DLink<T>(value, pre, pre->next);
	pre->next->pre = newNode;
	pre->next = newNode;
	curLength++;
	return true;
}

template<typename T>
inline bool DInkList<T>::Delete(int i)
{
	if (i > curLength - 1 || i <= -1)
	{
		std::cout << "invalid position" << std::endl;
		return false;
	}

	DLink<T>* pre = setPos(i - 1);
	DLink<T>* node = pre->next;
	pre->next = node->next;
	node->pre = pre;
	delete node;
	curLength--;

	return true;
}

template<typename T>
inline bool DInkList<T>::GetValue(int index, T& value)
{
	if (index > curLength - 1 || index < 0)
	{
		std::cout << "invalid position" << std::endl;
		return false;
	}

	int count = 0;
	DLink<T>* node = head->next;
	while (node != nullptr)
	{
		if (count == index)
		{
			value = node->data;
			return true;
		}
		node = node->next;
		count++;
	}
	return true;
}

template<typename T>
inline bool DInkList<T>::GetPos(int& p, T value)
{
	int count = 0;
	DLink<T>* node = head->next;
	while (node != nullptr)
	{
		if (node->data == value)
		{
			p = count;
			return true;
		}
		node = node->next;
		count++;
	}

	return false;
}
