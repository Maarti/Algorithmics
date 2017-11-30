t = int(input())  # read a line with a single integer
for i in range(1, t + 1):
    pancakes,flipper = input().split(" ")
    flipper = int(flipper)
    pancakes = list(pancakes)
    #print("Case #{}: {} {}".format(i, pancakes, flipper)) 
    nbPancakes = len(pancakes)
    nbFlip = 0
    for p in range(0,nbPancakes-1):
        if pancakes[p] == "-":
            
            # if max is reached, flip the last 3 pancakes
            if p+flipper>nbPancakes-1:
                for l in range(nbPancakes-flipper,nbPancakes):
                    pancakes[l]= "-" if pancakes[l]=="+" else "+"
            
            # else, flip the 3 next pancakes
            else:
                for l in range(p,p+flipper):
                    pancakes[l]= "-" if pancakes[l]=="+" else "+"
            nbFlip+=1
            #print("flip({}) = {}".format(nbFlip,pancakes))
    #print("{}".format(pancakes))
    if "-" in pancakes:
        nbFlip="IMPOSSIBLE"
    print("Case #{}: {}".format(i, nbFlip))
