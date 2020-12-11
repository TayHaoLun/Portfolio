#Name:Tay Hao Lun
#Subject Code:CSIT110
#Student Number:10195742

import csv
filePath = "data.csv"
with open(filePath) as csvfile:
    reader = csv.DictReader(csvfile)
    names=[]
    tribes=[]
    ids=[]
    Airs=[]
    Waters=[]
    Earths=[]
    Fires=[]
    for row in reader:
        name=row['name']
        tribe=row['tribe']
        id=row['id']
        Air=row['Air']
        Water=row['Water']
        Earth=row['Earth']
        Fire=row['Fire']
        names.append(name)
        tribes.append(tribe)
        ids.append(id)
        Airs.append(Air)
        Waters.append(Water)
        Earths.append(Earth)
        Fires.append(Fire)        


id_check =input("Enter Avatar ID:")
while True:
    if (id_check == ''):
        print("Empty input, please enter again")
        id_check = input("Enter Avatar ID:")
    if(id_check!=''):
            if (id_check in ids ):
                idindex=ids.index(id_check)
                theName=names[idindex]
                thetribe=tribes[idindex]
                theAir=Airs[idindex]
                theWater=Waters[idindex]
                theEarth=Earths[idindex]
                theFire=Fires[idindex]
                
                print("=====================================")
                print("{0:<9}{1:^14}{2:^14}".format("Avatar ID |"," Avatar Name |"," Avatar Tribe"))
                print("{0:<9}{1:^3}{2:>12}{3:^1}{4:^14}".format(id_check,"|", theName,"|",thetribe))
                print("=====================================")
                print("Four Elements Power")
                print("=====================================")
                print("{0:^7}{1:<6}{2:>8}{3:>7}{4:>7}".format("Air |","Water |","Earth |","Fire |"," Average Power"))
                Average=(float(theAir)+float(theEarth)+float(theFire)+float(theWater))/4
                print("{0:^5}{1:<5}{2:<3}{3:<5}{4:<3}{5:<4}{6:<3}{7:<4}{8:^4}".format(theAir,"|",theWater,"|",theEarth,"|",theFire,"|",Average))
                print("=====================================")
                break
            else:
                print("No Avatar record found")
                id_check = str(input("Enter Avatar ID:"))            
            
    
           
     
           
            
           
    
       
                  
                     
                
             
        
   


 
 