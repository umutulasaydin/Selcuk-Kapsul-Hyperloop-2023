import socket
import serial
import os
import threading

pod = serial.Serial(port = "/dev/ttyUSB0", baudrate=115200)
print("Bağlandı")
host = os.popen("ip -4 route show default").read().split()[8]
port = 1025
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.bind((host, port))
sock.listen()
print("Binding tamamlandi. Port dinleniyor")
print(host, port)
conn, addr = sock.accept()
print("Baglanti adresi: {}\n".format(addr))
pod.flush()
def VeriAl():     
        while True:
            try:
                data = ""
                data = pod.readline().decode()
                if (len(data) != 0):
                    if (data.startswith("!") == False):
                        data = data[:-2]
                        x = os.popen("ping "+host +" -c 1").read()
                        x =x[x.find("time=")+5:x.find("ms")]
                        data+= "/"+x+"\n"
                    data = data.encode()
                    conn.send(data)
                    print("Veri: " + data.decode())
              
                
                   
            except Exception as s:
                print("BAĞLANTI KESİLDİ")
                print(s)
                conn.close()
                sock.close()
                pod.close()
                return

def KomutAl():   
        while True:
            try:
                string, addr = conn.recvfrom(1024)
                value = int.from_bytes(string, "big")
                if (value != 20):
                    print("EMİR:", value)
                    pod.write(value.to_bytes(2, "big"))
                if (value == 0):
                    pod.write(value.to_bytes(2, "big"))
                    break
               
            except Exception as s:
                print("BAĞLANTI KESİLDİ")
                print(s)
                conn.close()
                pod.close()
                sock.close()


veri = threading.Thread(target=VeriAl)
veri.start()
KomutAl()