t = int(input())
for i in range(1, t + 1):
  # Init
  nbStall,nbPrsn = input().split(" ")
  nbStall,nbPrsn = int(nbStall),int(nbPrsn)
  print("nbStall = {} nbPrsn = {}".format(nbStall,nbPrsn))
  stalls = [0]*(nbStall+2)
  stalls[0],stalls[nbStall+1] = 1,1
  
  if nbPrsn >= nbStall:
    max,min=0,0
  else:
    max = 1
    min = 1
  print("Case #{}: {} {}".format(i, max,min))
