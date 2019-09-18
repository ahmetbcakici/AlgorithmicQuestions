def getsumofsquares(start,finish):
    sum = 0
    for i in range(start,finish + 1):
        sum += i * i
    return sum
def getsquareofsum(start,finish):
    sum = 0
    for i in range(start,finish + 1):
        sum += i
    return sum * sum
print(getsquareofsum(1,100) - getsumofsquares(1,100))