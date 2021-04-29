###DTO

class SkypeError():

    def __init__(self, name =None, mail=None, company=None, License=None, officeVersion = None, M365User=None):
        self.name = name
        self.mail = mail
        self.company = company
        self.License = License
        self.officeVersion = officeVersion
        self.M365User = M365User

    def __str__(self):
        return 'name:'+self.name+',mail:'+self.mail+',company:'+self.company+',Lisence:'+self.License+',officeVersion:'+self.officeVersion+',M365User:'+self.M365User



###DAO

import pymysql
import Tool.SkypeError.dto as dto

class dao():
    def connect(self):
        return pymysql.connect(, db='spam', charset='utf8')

    def insert(self,u):
        conn = self.connect() #Create DB Connection
        sql = 'insert into skypeerror(name, mail, company, License, officeVersion, M365User) values(%s,%s,%s,%s,%s,%s)' #SQL insert Query
        cursor = conn.cursor() # Define Cursor
        user = (u.name, u.mail, u.company, u.License, u.officeVersion, u.M365User) #  Customer 개체 생성
        cursor.execute(sql,user) #SQL에 Customer 개체 삽입
        conn.commit()#적용
        conn.close()
        
        
###Main

import tkinter as tk
from tkinter import messagebox
from tkinter import ttk

import Tool.SkypeError.dao as skype_dao
import Tool.SkypeError.dto as skype_dto

dao = skype_dao.dao()



class F:

    def insert():
        name = enterName.get()
        mail = enterMail.get()
        company = enterCompany.get()
        license = enterLicense.get()
        officeversion = enterofficeVersion.get()
        m365user = enterM365User.get()


        userInfo = skype_dto.SkypeError(name, mail, company, license, officeversion, m365user)
        messagebox.showinfo("Registration", "Information Successfully Registered")

        return dao.insert(userInfo)


root = tk.Tk()
root.title('Skype Error JDBC')
root.geometry('480x300+200+100')
root.resizable(False, False)
label = tk.Label(root, text="REGISTRATION", height=8).grid(row=0, column=1)
emp1 = tk.Label(root, text="NAME = ").grid(row=1, column=0)
emp2 = tk.Label(root, text="MAIL ADDRESS = ").grid(row=2, column=0)
emp3 = tk.Label(root, text="COMPANY CODE = ").grid(row=3, column=0)
emp4 = tk.Label(root, text="LICENSE = ").grid(row=4, column=0)
emp5 = tk.Label(root, text="OFFICE VERSION = ").grid(row=5, column=0)
emp6 = tk.Label(root, text="M365 USER (T/F) = ").grid(row=6, column=0)
btn1 = tk.Button(root, text="ENTER", command=F.insert).grid(row=4,column=2)

enterName = tk.Entry(root, width=40)
enterName.grid(row=1, column=1)
enterMail = tk.Entry(root, width=40)
enterMail.grid(row=2, column=1)
enterCompany = tk.Entry(root, width=40)
enterCompany.grid(row=3, column=1)
enterLicense = tk.Entry(root, width=40)
enterLicense.grid(row=4, column=1)
enterofficeVersion = tk.Entry(root, width=40)
enterofficeVersion.grid(row=5, column=1)
enterM365User = tk.Entry(root, width=40)
enterM365User.grid(row=6, column=1)



root.mainloop()
