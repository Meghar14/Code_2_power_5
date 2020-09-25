// cerner_2^5_2020
package main
import (
    "strings"
    "code.google.com/p/go-tour/wc"
)
func WordCount(s string) map[string]int {
    words := strings.Fields(s)
    wordCount := make(map[string]int)
    for i := range words {
        wordCount[words[i]]++
    }
        
    return wordCount
}

func main() {
    wc.Test(WordCount)
}