
// 双链表结点定义与实现
template <typename T> class DLink
{
public:
	T data;
	DLink<T>* next;
	DLink<T>* pre;

	DLink(const T data, DLink<T>* pre, DLink<T>* next)
	{
		this->data = data;
		this->pre = pre;
		this->next = next;
	}

	DLink(DLink<T> * pre,DLink<T> * next)
	{
		this->pre = pre;
		this->next = next;
	}
};

