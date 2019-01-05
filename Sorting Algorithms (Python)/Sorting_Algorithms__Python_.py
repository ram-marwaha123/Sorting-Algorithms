def Quicksort(arr, start, end):
	if (end > start):
		pivot = Partition(arr, start, end)
		Quicksort(arr, start, pivot - 1)
		Quicksort(arr, pivot + 1, end)

def Partition(arr, p, q):
	pivot = q
	i = p - 1
	for j in range(p, pivot):
		if (arr[j] < arr[pivot]):
			i += 1
			arr[i], arr[j] = arr[j], arr[i]
	pivot = i + 1
	arr.insert(pivot, arr.pop(q))
	return pivot

l = [10, 5, 6, 1, 7, 12, 5, 6, 124]
Quicksort(l, 0, len(l) - 1)
print (l)