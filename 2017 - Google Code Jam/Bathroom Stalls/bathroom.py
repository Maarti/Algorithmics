t = int(input())
for i in range(1, t + 1):
  # Init
  nbStall,nbPrsn = input().split(" ")
  nbStall,nbPrsn = int(nbStall),int(nbPrsn)
  print("nbStall = {} nbPrsn = {}".format(nbStall,nbPrsn))
  stalls = [0]*(nbStall+2)
  stalls[0],stalls[nbStall+1] = 1,1
  
  # Datastructure
  if nbPrsn >= nbStall:
    max,min=0,0
  else:
    values = []
    for index in range(1,len(stalls)-1):
      if stalls[index] == 0:
        
        # Compute Ls
        j = index
        while stalls[j] == 0:
          j-=1
        Ls = index - j
        
        # Compute Ls
        j = index
        while stalls[j] == 0:
          j+=1
        Rs = j - index        

        values.append({"index":index,"Ls":Ls,"Rs":Rs})
        
    print(values)
    max = 1
    min = 1
  print("Case #{}: {} {}".format(i, max,min))
