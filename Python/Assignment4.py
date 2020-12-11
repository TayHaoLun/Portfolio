import csv
filePath = "data.csv"
with open(filePath) as csvfile:
    read = csv.DictReader(csvfile)
    avatar = {}
    ids = []
    same=[]
    avatarinfos = []
    for row in read:
        id=row['id']
        same.append(id)
        ids.append(row['id'])
        avatarinfo = [row['name'],row['tribe'],row['id'],row['Air'],row['Water'],row['Earth'],row['Fire']]
        avatar[row['id']] = avatarinfo
        
def menu():
    print("Avatar Management System")
    print("1: Insert a new avatar")
    print("2: Delete a avatar")
    print("3: Save data to file and exit")
    choice = input("Enter choice: ")
    print()
    if (choice == str(1)):
        avatarinfo=insert()
        newid=avatarinfo[2]
        avatar[newid] = avatarinfo
        for s in same:
            if (newid[0]==s[0] and newid[1]==s[1] and newid[2]==s[2] and newid[3]==s[3]):
                print("Avatar id was existed.")
                print("Please input again.")
                avatarinfo=insert()
                newid=avatarinfo[2]
                avatar[newid] = avatarinfo                
        else:
            print("New Avatar with ID " + newid + " Inserted.")
            print("Back to menu.")                
            ids.append(newid)     
            print()                
        return choice       
    elif (choice == str(2)):
        delete()
        return choice
    elif (choice == str(3)):
        saveandexit()
        exit()
    else:
        print("===============================================")
        print("Invalid choice, please enter again.") 
        print("===============================================")
        return choice

def insert():
    print("Insert new avatar")
    name = input("Enter name: ")
    id = input("Enter id three integers: ")
    if(len(id)!=3):
        print("invalid id")
        id = input("Enter id three integers: ")
    tribe = input("Enter tribe: ")
    air = input("Air:")
    water = input("Water:")
    earth = input("Earth:")
    fire = input("Fire:")
    average = (int(fire) + int(water) + int(earth) + int(air))/4
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
    firstletter = tribe[0].upper()
    newid = firstletter + id + averageletter
    avatarinfotable = [name, tribe, newid, air, water, earth ,fire]
    return avatarinfotable
       
        
def delete():
    inputid = input("Enter avatar id to delete:")
    if inputid in avatar:
        del avatar[inputid]
        ids.remove(inputid)
        same.remove(inputid)
    else:
        print("Avatar ID is not found.")
        print("Please input again.")
        delete()
    print()
    print("Avatar Record Deleted.")
    print("Back to menu.")
    
def saveandexit():
    maxlengthid = len(ids)
    filePath = "data.csv"
    with open(filePath, 'w', newline='') as csvfile:    
        for i in range(maxlengthid):
            profile = avatar[ids[i]]
            fieldnames = ['name', 'tribe', 'id', 'Air', 'Water', 'Earth', 'Fire']
            writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
            if(i == 0):
                writer.writeheader()
            writer.writerow({'name': profile[0],				
                             'tribe': profile[1],
                             'id': profile[2],
                             'Air': profile[3],
                             'Water': profile[4],
                             'Earth': profile[5],
                             'Fire': profile[6]})           
    print("Data file saved.")
    print("Thank you for using the Avatar Management System.")

      
while True:    
    menu()
    

