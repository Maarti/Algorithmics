import math

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
    for p in range(nbPrsn):
      values = []
      start,size=-1,0
      for index in range(1,len(stalls)):
        if stalls[index] == 0:
          if start == -1:
            start = index
          size+=1
        elif size>0:
          values.append({"start":start,"size":size,"best":math.ceil(size/2+start-1)})
          start,size=-1,0    
      
      # Choose the better
      size = -1
      for index in range(len(values)):
        if values[index]["size"] > size:
          size = values[index]["size"]
          choice = values[index]["best"]
      print("prsn:{} choice:{}".format(p,choice))
      stalls[choice] = 1

    max = 1
    min = 1
  print(stalls)
  print("Case #{}: {} {}".format(i, max,min))
  print("")
