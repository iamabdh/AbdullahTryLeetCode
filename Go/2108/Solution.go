package _108

func FirstPalindrome(words []string) string {
	for _, val := range words {
		reverse := func(str string) string {
			strByte := []rune(str)
			var newArr []rune
			for i := len(strByte) - 1; i >= 0; i-- {
				newArr = append(newArr, strByte[i])
			}
			return string(newArr)
		}
		if val == reverse(val) {
			return val
		}
	}
	return ""
}
