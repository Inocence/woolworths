import pyodbc
import shutil
import os
import time
import subprocess

def execute_sqlcmd(command):
    try:
        sqlcmd_command = f"sqlcmd -S white\\SQLEXPRESS -E -Q \"{command}\""
        result = subprocess.run(sqlcmd_command, shell=True, capture_output=True, text=True)

        if result.returncode == 0:
            print("Command executed successfully.")
            print(result.stdout)
        else:
            print("Error occurred:")
            print(result.stderr)
    except Exception as e:
        print(f"An error occurred: {e}")

def delete_folder(folder_path):
    if os.path.exists(folder_path):
            shutil.rmtree(folder_path)

def execute_dotnet_commands():
    try:
        subprocess.run(["dotnet", "ef", "migrations", "add", "Init"], check=True)
        print("dotnet ef migrations add Init")

        subprocess.run(["dotnet", "ef", "database", "update"], check=True)
        print("dotnet ef database update")
    except subprocess.CalledProcessError as e:
        print(f"Error executing dotnet command: {e}")

if __name__ == "__main__":
    db_name = "woolworths"
    commands = [
        #"USE master;",
        #f"ALTER DATABASE {db_name} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;",
        f"DROP DATABASE {db_name};"
    ]
    for command in commands:
        execute_sqlcmd(command)

    work_path = "C:\\home\\code\\woolworths\\woolworths"
    os.chdir(work_path)

    delete_folder(work_path + "\\Migrations")
    execute_dotnet_commands()