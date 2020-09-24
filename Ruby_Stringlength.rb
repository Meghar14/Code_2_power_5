// cerner_2^5_2020
// Ruby program to find number of words in a string"
puts "Enter the string"
str1 =gets.chomp
count=1
for i in 1 str1.Length
        if(str1[i]==' ')
        count+=1
        end
end
puts "Number of words are #{count}"