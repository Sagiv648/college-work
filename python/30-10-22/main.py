def Q1(sequence):
    output = 0
    for num in sequence:
        temp = num //10
        firstDigit = num % 10
        while(temp):
            if(firstDigit % 2 != (temp % 10) % 2):
                break
            temp //=10
        if(not temp):
            output += 1
    return output

#print(Q1((226,4,2044,17,826)))

def Q2(list):
    
    outputList = []
    neg_or_pos = lambda x: (x * (x > 0)) + ((x * (x < 0))*-1)
    
    i = 0
    while(i <= 9):
        for num in list:
            if(len(str(neg_or_pos(num))) == i):
                outputList.append(num)
        i+=1
    return outputList

print(Q2([18,9876,-5,45,1000,43256,-165,2]))

Q3 = lambda x: (x%10) + (x//10%10) + (x//100)
Q4 = lambda x: (x//10 % 10) * (x//100 % 10) * (x //1000 % 10)
Q5 = lambda x: ((x%10 * 10) + (x //10 % 10)) * 10 + (x //100)
Q6 = lambda x: bool(x % 10 % 2 * x // 10 % 10 % 2)

Q7 = lambda x,y: bool((str(x).find(str(y)[0]) >= 0) * (str(x).find(str(y)[1]) >= 0) * (str(x).find(str(y)[2]) >= 0))

Q8 = lambda x,y: ((y % 2 == 0) * int(pow(x,y))) + ((y % 2 == 1) * int(pow(x,1/2)))       
Q9 = lambda x: ((x > 0)*1) + ((x < 0)*2) + (x == 0)*3






            
