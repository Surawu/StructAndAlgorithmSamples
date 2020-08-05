#include <list>
#include <iostream>

template <typename T> class arrList
{
public:
	arrList(const int size) {
		maxSize = size;
		aList = new T[maxSize];
		curLen = position = 0;
	}

	~arrList()
	{
		delete[] aList;
	}
	void Clear()
	{
		delete[] aList;
		curLen = position = 0;
		aList = new T[maxSize];
	}

	int Length()
	{
		return curLen;
	}

	bool Append(const T value)
	{
		if (curLen >= maxSize)
			std::cout << "this list is overflow" << std::endl;

		aList[curLen - 1] = value;
	}

	bool Insert(const int p, const T value)
	{
		if (curLen >= maxSize)
			std::cout << "this list is overflow" << std::endl;

		if (p<0 || p>curLen)
			std::cout << "insert position is illegal" << std::endl;

		for (int i = curLen; i > p; i--)
		{
			aList[i] = aList[i - 1];
		}

		aList[p] = value;
		curLen++;
		return true;
	}

	bool Delete(const int p)
	{
		if (p<0 || p>curLen - 1)
			std::cout << "delete position is illegal" << std::endl;

		if (curLen <= 0)
			std::cout << "no element to delete" << std::endl;

		for (int i = p; i < curLen - 1; i++)
		{
			aList[p] = aList[p + 1];
		}

		curLen--;
		return true;
	}

	bool SetValue(const int p, const T value)
	{
		if (p<0 || p>curLen - 1)
			std::cout << "set position is illegal" << std::endl;

		if (curLen <= 0)
			std::cout << "no element to set" << std::endl;

		aList[p] = value;
		return true;
	}

	bool GetValue(const int p, T& value)
	{
		if (p<0 || p>curLen - 1)
			std::cout << "set position is illegal" << std::endl;

		if (curLen <= 0)
			std::cout << "no element to set" << std::endl;

		value = aList[p];
		return true;
	}

	bool GetPos(int& p, const T value)
	{
		for (int i = 0; i < curLen - 1; i++)
		{
			if (curLen[i] == value)
			{
				p = i;
				return true;
			}
		}

		return false;
	}

private:
	T* aList;
	int maxSize;
	int curLen;
	int position;
};


