package _4

func SearchRange(nums []int, target int) []int {
	arr := []int{-1, -1}
	for index, val := range nums {
		if val == target {
			arr[0] = index
			break
		}
	}
	for i := len(nums) - 1; i >= 0; i-- {
		if nums[i] == target {
			arr[1] = i
			break
		}
	}
	return arr
}
