def Q1(x):
    listeven, listodd = [], []

    for i in x:
        element = i
        sum = 0
        while element > 0:
            sum += element % 10
            element //= 10

        if sum % 2 == 0:
            listeven.append(i)
        else:
            listodd.append(i)

    if len(listeven) > len(listodd):
        return listodd + listeven
    elif len(listeven) < len(listodd):
        return listeven + listodd
    else:
        return []
test = [18,93,2,45,100,1021,15,5]




def Q2(str):
    words = str.split()
    i = 0
    arbitraryList = []
    outputList = []
    while(i < len(words)):
        arbitraryList = words[i].split('@')
        
        if(len(arbitraryList) != 2):
            i+=1
            continue

        if(arbitraryList[0][0] == '.' or arbitraryList[1][len(arbitraryList)-1] == '.'):
            i+=1 
            continue
        outputList += arbitraryList
        i+=1
    i=0
    tempList = []
    while(i < len(outputList)):
        tempList = outputList[i+1].split('.')
        if(len(tempList) == 2):
            print("Email is: %s@%s" %(outputList[i], outputList[i+1]))
        i+=2
    

    

#Q2("hadad@hotmail.com david.c@om david@gmail.com sagivalia11@gmail.com 054-111111")


def Q3(str):
    words = str.split()
    mid = len(words)//2
    i = 0
    k = len(words)//2
    while(i < mid):
        k = len(words)//2
        while(k < len(words)):
            if(words[i] == words[k]):
                
                return True
            k+=1
        i+=1
    return False
    
#print(Q3("london is the capital of great is britian"))


def Q4(strOne, strTwo):
    allWords = strOne.split() + strTwo.split()
    i = 0
    while(i < len(allWords)):
        k = i+1
        while(k < len(allWords)):
            if(len(allWords[i]) > len(allWords[k])):
                tmp = allWords[i]
                allWords[i] = allWords[k]
                allWords[k] = tmp
            k+=1
        i+=1
    print(" ".join(allWords))
    

#Q4("aaa bcd abcd aaa", "aa abcd bb ab 123 qwerty")

def Q5(x):
    for i in range(0, len(x)):
        if(str(x[i]) == str(x[i])[::-1]):
            isGood = True
            allNum = [0]*10
            for char in str(x[i]):
                allNum[int(char)] += 1
                if(allNum[int(char)] > 2):
                    isGood = False
                    break
            if(isGood):
                return x[i]
        i+=1
    return 0
            

#print(Q5([12121,46,98889,1111,144]))

def Q6(str):
    splitted = str.split('(')
    args = splitted[1].split(',')
    if(len(args) != 2):
        return 0
    argOne = args[0]
    argTwo = args[1][:-1]
    if(splitted[0] == 'add'):
        return int(argOne) + int(argTwo)
    elif( splitted[0] == 'sub'):
        return int(argOne) - int(argTwo)
    elif(splitted[0] == 'mul'):
        return int(argOne) * int(argTwo)
    

print(Q6('mul(15,-5)'))
    