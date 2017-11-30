#We read the number from right to left, digit by digit
#If the digit is lesser than the next digit to the right,
#we subtract (digit+1) from the number.
#(multiplied by 10 if its the digit of the tens, 100 if it's the hundres,...)

t = int(input())
for i in range(1, t + 1):
  number = list(input())
  print("number={}".format(number))
  length = len(number)
  
  if length==1:
    answer = number[0]
  
  else:
    mult=1
    for d in range(length-1, -1, -1):
      print(" digit={}".format(number[d]))
      if d!=0:

        #if digit lesser than the previous
        if(number[d] < number[d-1]):
          numberStr = ''.join(number)
          newNumber = int(numberStr) -(int(number[d])+1)*mult
          print("{} - ({} + 1)*{}".format(numberStr,number[d],mult))
          number = list(str(newNumber))
      mult*=10
      
    answer = number
  print("Case #{}: {}".format(i, answer))
  print("")
    
