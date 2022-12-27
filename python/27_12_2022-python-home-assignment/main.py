import os
from functools import reduce
path = os.getcwd()

import shutil



def Q1(fileName):
    allLines = []

    try:
        with open(fileName, 'r') as f:
            allLines = f.readlines()
    except OSError:
            if not(fileName in os.listdir(path)):
                print("File not located in the path.")
            else:
                print("Another I/O error.")
            return False       
    except:
            print("A different error occured")
    else:
        for line in allLines:
            sentences = line.split()
            if len(sentences) != 2:
                return False
            elif (sentences[0][0].islower()):
                return False
            if( not reduce(lambda x,y: x*1 if y.isnumeric() and (int(y) >= 0 and int(y)<= 100) else x * 0  ,sentences[1].split(','), 1)):
                return False
    return True
#print(Q1("q1.txt"))
    

def Q2(fileName, nameToSearch,newName):
    try:
        with open(fileName, 'r') as f:
            allLines = f.readlines()
    except OSError:
            if not(fileName in os.listdir(path)):
                print("File not located in the path.")
            else:
                print("Another I/O error.")
    except:
            print("A different error occured")
    else:
        try:
            with open("output-{0}".format(fileName),'x') as f:
                f.write("".join(allLines).replace(nameToSearch, newName))
        except OSError:
            print("Problems occured with the I/O")
        else:
            print("Created new file.")
            
            
#Q2("q2.txt", "cat", "dog")
    
def Q3(fileName):
    try:
        with open(fileName, 'r') as f:
            allLines = map(lambda x: x[:len(x)-1] ,f.readlines())
    except OSError:
            if not(fileName in os.listdir(path)):
                print("File not located in the path.")
            else:
                print("Another I/O error.")
    except:
        print("A a different error occured")
    else:
        listToWrite = []
        for line in allLines:
            sentence = line.split(':')
            if len(sentence) == 2 and sentence[1].rstrip('\n') == "":
                listToWrite.append("".join(sentence[0])+ " no temperature\r\n")

            elif len(sentence) == 2 and sentence[1] != "":
                listTemps = list(reduce(lambda x,y: x + [float(y)] if len(list(filter(lambda t: (t >= '0' and t <= '9') or t == '.' or y[0] == '-' ,y))) == len(y) else x ,sentence[1].split(','),[]))
                listToWrite.append("".join(sentence[0]) + ": avg({0}),min({1}), max({2})\r\n".format(reduce(lambda x,y: x+y ,listTemps, 0) / len(listTemps), min(listTemps), max(listTemps) 
                ) if len(listTemps) == len(sentence[1].split(',')) else "".join(sentence[0]) + ": {0}  temperature error\r\n".format(sentence[1]))

            else:
                listToWrite.append("".join(line) + " line error\r\n")
        try:
            with open("output-{0}".format(fileName),'x') as f:
                f.write("".join(listToWrite))
        except OSError:
            if not(fileName in os.listdir(path)):
                print("File not located in the path.")
            else:
                print("Another I/O error")
        except:
            print("A different error")

#Q3("q3")

def Q4(path):
    dic = {}
    for file in os.listdir(path):
        extenstion = file.split('.')[len(file.split('.'))-1]
        dic[extenstion] = dic.get(extenstion,[]) + [file]
    for key,val in dic.items():
        folderPath = "{0}\\{1}".format(path,key)
        os.mkdir(folderPath)
        for f in val:
            shutil.move("{0}\\{1}".format(path,f),"{0}\\{1}".format(folderPath,f))

#Q4(os.getcwd()+"\\test")
