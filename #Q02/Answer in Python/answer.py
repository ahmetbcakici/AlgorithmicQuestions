number = int(input("Enter a number:"))
cntr = 0
i = 2
while True:
    if cntr >= number:break
    else:
        for j in range(2,i,1):
            if i % j == 0:
                break
        else:
            print(i,end = " ")
            cntr+=1
    i+=1