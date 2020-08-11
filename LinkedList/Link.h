
template <typename T> class Link
{
public:
	T data;
	Link<T>* next;

	Link(const T info, Link<T>* nextValue)
	{
		data = info;
		next = nextValue;
	}

	Link(Link<T>* nextValue)
	{
		next = nextValue;
	}
};

