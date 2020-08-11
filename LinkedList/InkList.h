
template <typename T> class InkList :public list<T>
{
private:
	Link<T>* head, * tail;
	Link<T>* setPos(const int i)
	{
		int count=0;
		if (i==-1)
		{
			return head;
		}
		
		Link<T> *p=new Link<T>(head->next);
		while (p!=NULL && count <i)
		{
			p=p->next;
			count++;
		}
		return p;
	}

public:
	InkList(int s);

	~InkList();
	bool IsEmpty();
	void Clear();
	int Length();
	bool Append(T value);
	bool Insert(int p, T value);
	bool Delete(int p);
	bool GetValue(int p, T& value);
	bool GetPos(int& p, T value);
};

template<typename T>
inline InkList<T>::InkList(int s)
{
	head = tail = new Link<T>();
}

template<typename T>
inline InkList<T>::~InkList()
{
	Link<T>* tmp;
	while (head != NULL)
	{
		tmp = head;
		head = head->next;
		delete tmp;
	}
}

template<typename T>
inline bool InkList<T>::IsEmpty()
{
	return false;
}
