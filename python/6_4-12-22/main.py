import math


def Q1(*param):
    try:
        if(len(param) != 1):
            raise TypeError

        elif((type(param[0]) != int and type(param[0]) != float) or param[0] < 0):
            raise ValueError


    except TypeError:
        print("Above 1 argument" if len(param) > 1 else "No argument")
        return None
    except ValueError:
        print("Parameter has to be float or int" if type(param[0]) != int or type(param[0]) != float else "Negative")
        return None
    else:
        return math.sqrt(param[0])


def Q2(string):
    try:
        if(type(string) != str):
            raise TypeError
        words = string.split('/')
        if(len(words) != 3):
            raise TypeError
        if(not(1 < int(words[0]) < 30)):
            raise ValueError
        elif( not(1 < int(words[1]) < 12)):
            raise ValueError
        elif( not(0 < int(words[2]) < 10000)):
            raise ValueError

    except TypeError:
        if(type(string) == str and len(words) != 3):
            print("Incorrect format")
        elif(type(string) != str):
            print("Incorrect type")
        return None
    except ValueError:
        if(not(1 < int(words[0]) < 30)):
            print("Day value error")
        elif( not(1 < int(words[1]) < 12)):
            print("Month value error")
        elif( not(0 < int(words[2]) < 10000)):
            print("Year value error")
    else:
        return "".join( str( (int(words[0]) + 1 % 30) ) + '/' + words[1] + '/' + words[2])
            


def Q3(*paramString):

    mapping = {'registration': (), 
    'doctor checkup' : (), 
    'procedure' : (), 
    'radiography' : (), 
    'blood' : (),
    'test' : (), 
    'hospital discharge' : ()}

    try:
        if(len(paramString) != 2):
            raise TypeError
        if(type(paramString[0]) != str or type(paramString[1]) != str):
            raise ValueError
        hourMin = paramString[0].split(':')
        if(len(hourMin) != 2):
            raise ValueError

        mapping[paramString[1]] += ( 
            (int(hourMin[0]), int(hourMin[1]),)
            , paramString[1])
    except TypeError:
        print("Incorrect type")
    except ValueError:
        print("Incorrect format")
    except KeyError:
        print("Incorrect station")
    else:
        return mapping[paramString[1]]




def Q4():
    try:
        l = [0]*10
        for i in range(0,10):
            firstInput = int(input("Enter number:"))
            secInput = int(input("Enter index"))
            if( not(100 <= firstInput < 1000) ):
                raise ValueError
            if( not(0 <= secInput < 10) ):
                raise IndexError

            l[secInput] = firstInput
    except ValueError:
        print("Incorrect value range")
    except IndexError:
        print("Incorrect index range")
    except TypeError:
        print("Incorrect format")
    else:
        return l

