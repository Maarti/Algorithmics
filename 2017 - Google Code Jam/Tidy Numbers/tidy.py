# We read the number from left to right, digit by digit
# If the digit is higher than the next digit to the right,
# we subtract "next digit+1" from the number.
# (multiplied by 10 if its the digit of the tens, 100 if it's the hundreds,...)
# Then we replace all following digits by 9
# We sometimes have to repeat this action for numbers like 442,553...

t = int(input())
for i in range(1, t + 1):
  number = list(input())
  #print("number={}".format(number))
  length = len(number)
  
  if length==1:
    answer = number[0]
  
  else:

    while True:
      digitChanged = False
      again = False
      
      for d in range(0, length):
        # if a digit has changed, just replace the rest with 9
        if digitChanged:
          number[d] = '9'
        else:
          if d!=length-1:

            #if digit is higher than the next
            if(number[d] > number[d+1]):
            
              # play the loop another time after this ?
              # (for cases like "553", "441",...)
              if d > 0 and number[d-1]==number[d]:
                again=True
      
              # compute the multiplier
              power = length - (d+2)
              mult=10**power
              
              # subtract          
              numberStr = ''.join(number)
              newNumber = int(numberStr) -(int(number[d+1])+1)*mult
              #print("{} - ({} + 1)*{} = {}".format(numberStr,number[d+1],mult,newNumber))
              
              # we format the number with zero-padding to keep the same array size
              numberFormat = '0'+str(length)+'d'
              number = list(format(newNumber,numberFormat))
              digitChanged = True
      if not again:
        break

    answer = int(''.join(number))
  print("Case #{}: {}".format(i, answer))
  #print("")
    
