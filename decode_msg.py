mapping = {'a':1,'b':2,'c':3,'d':4,'e':5,'f':6,'g':7,'h':8,'i':9, 'j':10,'k':11,'l':12,'m':13,'n':14,'o':15,'p':16,'q':17,'r':18,'s':19,'t':20,'u':21,'v':22,'w':23,'x':24,'y':25,'z':26}
reversemap = {y:x for x,y in mapping.items()}


def do_work(data, step, length, result):
  s = len(data)-length

  if s == len(data):
    return False

  num = int(data[s:s+step])

  if num in reversemap:
    result.append(reversemap[num])
  
  do_work(data,step,length-1,result)
  do_work(data,step+1,length-1,result)

  return True

def num_ways(data, length, result):
  for i in [1,2]:
    do_work(data, i, length, result)

if __name__ == "__main__":
    #i = '111'
    i = '12345'
    
    result=[]
    num_ways(i, len(i), result)
    print(set(result))
