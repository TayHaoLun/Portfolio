#Name:Tay Hao Lun
#Subject Code:CSIT110
#Student Number:6276040

import csv
def isValidAvatarIDFormat():
    comment="" 
    if(len(id)==5 and id[0]==tribe[0].upper() and id[1].isnumeric()==True and id[2].isnumeric()==True and id[3].isnumeric()==True and id[4]==averageletter.upper()):
        comment="Valid"
        print("{0:^10}{1:>4}{2:^11}{3:^2}{4:<20}".format(name,"|",id,"|",comment))
        pass
    else:
        if(len(id)!=5):
            comment="Length of Avatar ID is not 5"
        elif(id[0]!=tribe[0] and id[0]!=tribe[0].upper()):
            comment="Invalid first letter"
        elif(id[4]!=averageletter and id[4]!=averageletter.upper()):
            comment="Invalid last letter"
        elif not (id[1].isnumeric() and id[2].isnumeric() and id[3].isnumeric()==True):
            comment="Invalid integer"
        print("{0:^10}{1:>4}{2:^11}{3:^2}{4:<20}".format(name,"|",id,"|",comment))
        

filePath = "data.csv"
with open(filePath) as csvfile:
    reader = csv.DictReader(csvfile)
    print(" Avatar Name | Avatar ID | Comments")
    for row in reader:
        id=row['id']
        name=row['name']
        tribe=row['tribe']
        air=int(row['Air'])
        water=int(row['Water'])
        earth=int(row['Earth'])
        fire=int(row['Fire'])        
        average=(air+water+earth+fire)/4
        averageletter=""
        if(average>=80):
            averageletter="A"
        elif(average>=70)and(average<80):
            averageletter="B"
        elif(average>=60)and(average<70):
            averageletter="C"
        elif(average>=50)and(average<60):
            averageletter="D"
        elif(average>=40)and(average<50):
            averageletter="E"
        elif(average<40):
            averageletter="F"
        comment=isValidAvatarIDFormat()
      
        
            


