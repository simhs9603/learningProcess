#import stock price from web (naver finance)


from bs4 import BeaurifulSoup #BeautifulSoap = analize html query at python
from datetime import datetime #import currunt time 
import requests #import URL Info. 
import time #update every 1 min

def get_code(company_code):
	url = "https://finance.naver.com/item/main.nhn?code="+company_code #import stock info match up with company code
	result = requests.get(url) #import info from url
	bs_obj = BeautifulSoup(result.content, "html.parser")
	return bs_obj
	
def get_price(company_code):
	bs_obj = get_code(company_code)
	no_today = bs_obj.find("p", {"class":"no_today})
	blind = no_today.find("span",{"class":"blind"})
	now_price = blind.txt 
	return now_price
	
company_codes = ["028300"]

while True:
	now = datetime.now()
	
	for item in company_codes:
		now_price = get_price(item)
		print(now_price)
		
	time.sleep(60) #update price every 60sec
	
	
	### one problem (working on) : stock price shown as "None" Probably blind.txt has some problems.###
