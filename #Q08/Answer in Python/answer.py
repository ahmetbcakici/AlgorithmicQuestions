flag = False
max = 0
for i in range(1000,99,-1):
    for j in range(1000,99,-1):
        result = i * j
        if str(result)[::-1] != str(result):
            flag = True
        if flag != True:
            if(result > max):
                max = result
        else:
            flag = False
print(max)