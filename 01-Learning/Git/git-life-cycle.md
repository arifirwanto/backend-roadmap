# Apa itu Working Directory?
Working Directory adalah folder project di komputer tempat kita membuat, mengubah, dan menghapus file sebelum perubahan tersebut dimasukkan ke Git.

# Apa itu Staging Area?
adalah tempat penyimpanan hasil penambahan atau perubahan file project kita sebelum di simpan ke local repsitory kita

# Apa itu Local Repository?
adalah tempat penyimpanan local kita atau pada laptop kita sebelum di push ke remote repository

# Apa itu Remote Repository?
Remote Repository adalah repository yang berada di server atau cloud seperti GitHub sehingga project dapat dibagikan dan dikerjakan bersama oleh banyak developer.

# Diagram alurnya.
Working Directory
        │
        │
   git add
        │
        ▼
 Staging Area
        │
        │
 git restore --staged
        ▲
        │
        │
 git commit
        ▼
 Local Repository
        │
        │
   git push
        ▼
 Remote Repository