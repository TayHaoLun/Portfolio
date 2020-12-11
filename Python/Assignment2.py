#Name:Tay Hao Lun
#Subject Code:CSIT110
#Student Number:10195742

import csv
filePath = "data.csv"
with open(filePath) as csvfile:
    reader = csv.DictReader(csvfile)
    names=[]
    Airs=[]
    Waters=[]
    Earths=[]
    Fires=[]
    for row in reader:
        name=row['name']
        Air=row['Air']
        Water=row['Water']
        Earth=row['Earth']
        Fire=row['Fire']
        names.append(name)
        Airs.append(Air)
        Waters.append(Water)
        Earths.append(Earth)
        Fires.append(Fire)

def menu():
    print("=================================")
    print("1:Display element average")
    print("2:Display avatar top element")
    print("0:Exit")
    choice=input("Enter choice:")
    if(choice=='1'):
        display_element_average()
        return choice
    if(choice=='2'):       
        display_avatar_top_elements()
        return choice
    if(choice=='0'):
        print("===============================================")
        print("Thank you for using Avatar Element System")
        print("===============================================")
        exit()
    else:
        print("=================================")
        print("Invalid choice,please enter again")
        return choice

def display_element_average ():
    sum=0
    sum1=0
    sum2=0
    sum3=0
    for num in Airs:
        sum+=int(num)
    for num in Waters:
        sum1+=int(num)
    for num in Earths:
        sum2+=int(num)
    for num in Fires:
        sum3+=int(num)    
    Airave  = sum / len(Airs)
    Waterave= sum1/len(Waters)
    Earthave= sum2/len(Earths)
    Fireave= sum3/len(Fires)
    print("===============================================")
    print("Display Element Average")
    print("===============================================")
    print("{0:^7}{1:<6}{2:>8}{3:>7}".format("Air |","Water |","Earth |","Fire "))
    print("{0:^5}{1:<3}{2:^5}{3:<4}{4:^3}{5:<4}{6:<2}".format(Airave,"|",Waterave,"|",Earthave,"|",Fireave))
    print("===============================================")

def display_avatar_top_elements():
    print("===============================================")
    print("Display Avatar Top Element")
    print("===============================================")
    print("Avatar Name | Top Element")    
    for name in names:
        nameindex=names.index(name)
        theName=names[nameindex]
        theAir=Airs[nameindex]
        theWater=Waters[nameindex]
        theEarth=Earths[nameindex]
        theFire=Fires[nameindex]
        max_num=max(int(theAir),int(theWater),int(theEarth),int(theFire))
        element=""
        if(max_num==int(theAir)):
            element += "Air"+" "
        if(max_num==int(theWater)):
            element += "Water"+" "
        if(max_num==int(theEarth)):
            element += "Earth"+" "
        if(max_num==int(theFire)):
            element += "Fire"+" "
        print("{0:^7}{1:>6}{2:<8}".format(name,"|",element))
    

print("================================")
print("Welcome to Avatar Element System")                
while True:   
    menu()