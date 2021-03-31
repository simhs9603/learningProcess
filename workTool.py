import os
import tkinter as tk
from tkinter import ttk
from tkinter import messagebox


class Func():

    def ipAll():
        command = os.system('start cmd /k ipconfig/all')

    def ping():
        global companyList
        getCompany = companyList.get()
        if getCompany == 'hmx':
            os.system('start cmd /k ping owa.hyundaimovex.com')
        elif getCompany == 'hda':
            os.system('start cmd /k ping owa.hdasan.com')
        else:
            os.system('start cmd /k ping owa.'+getCompany+'.co.kr')

    def pingEmailHyundai():
        os.system('start cmd /k ping email.hyundaigroup.com')

    def hostOpen():
        file = open('c:\\Windows\\System32\\drivers\\etc\\hosts','r')


















rt = tk.Tk()

rt.title("PC INFO Verf")
rt.geometry('1028x720+550+150')
rt.resizable(False,False)
companyList = ttk.Combobox(rt, width=20, textvariable = str)
companyList['values']=("hdel", "hdelsvc", "hmx", "hda", "hpd")
companyList.grid(row=1,column=1)
company = companyList.get()
print(companyList)



if company == 'hdel':
    messagebox.showinfo(company)
elif company == 'hdelsvc':
    company = 'hdelsvc'
elif company == 'hmx':
    company = 'hyundaimovex'
elif company == 'hda':
    company = 'hdasan'

tk.Button(rt, text='test', command=Func.ipAll).grid(row=2,column=2)
tk.Button(rt, text='test2', command=Func.ping).grid(row=3,column=2)
tk.Button(rt, text='test3', command=Func.hostOpen()).grid(row=4,column=2)
rt.mainloop()