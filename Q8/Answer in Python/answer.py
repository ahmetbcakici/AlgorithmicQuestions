flag = False
max = 0
for i in range(1000,99,-1):
    for j in range(1000,99,-1):
        result = i * j
        for k, l in zip(range(0, len(str(result))), range(len(str(result)) - 1, -1, -1)):
            if str(result)[k] != str(result)[l]:
                flag = True
                break
        if flag != True:
            if(result > max):
                max = result
        else:
            flag = False
print(max)