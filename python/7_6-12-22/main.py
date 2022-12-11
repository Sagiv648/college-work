


#Chosen assignment is: writing words counter
def wordCount(file):
    counter = {}
    with open(file, 'r') as f:
        text = "".join(f.readlines())
        for sentence in text.split('\n'):
            for textWord in sentence.split():
                counter[textWord] = counter.get(textWord,0) + 1
    return counter

print(wordCount("words.txt"))