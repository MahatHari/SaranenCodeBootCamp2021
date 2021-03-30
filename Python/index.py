
numList =[line.rstrip() for line in open('../num.txt')]
sum=0;
for a in numList:
    if a!="":
        sum+= int(a)
print sum