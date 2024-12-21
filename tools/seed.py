import pyodbc
import shutil
import os
import time
import subprocess

def seed_data(url):
    data = '{"key1": "value1", "key2": "value2"}'
    headers = 'Content-Type: application/json'

    command = [
        'curl',
        '-X', 'POST',
        url,
        '-H', headers,
        '-d', data
    ]

    try:
        # 捕获标准输出和错误输出
        response = subprocess.run(command, capture_output=True, text=True, encoding='utf-8')
        
        # 打印响应内容以调试
        print(f"Response from {url}: {response.stdout}")
        
        if response.stderr:
            print(f"Error: {response.stderr}")
    except Exception as e:
        print(f"Error while running subprocess: {e}")

if __name__ == "__main__":

    work_path = "C:\\home\\code\\woolworths\\woolworths"
    os.chdir(work_path)
    
    host = "http://localhost:5169/api/seed-data/"
    urls = [
        "init",
    ]
    for url in urls:
        api = host + url
        seed_data(api)