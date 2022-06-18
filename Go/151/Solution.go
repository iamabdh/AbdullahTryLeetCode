package _51

import "strings"

func ReverseWord(s string) string {
	s = strings.Trim(s, " ")
	a := strings.Split(s, " ")
	var arrStr []string
	for i := len(a) - 1; i >= 0; i-- {
		if a[i] != "" {
			arrStr = append(arrStr, a[i])
		}
	}
	return strings.Trim(strings.Join(arrStr, " "), " ")
}
