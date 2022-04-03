# Microservice
Microserviceler temelde bir yazılım uygulamasında belirli özellik yada fonksiyonu sağlayan, tek bir amaca hizmet eden, birbirinden bağımsız yazılım servislerdir. 
Bu hizmetler bağımsız olarak bakımı yapılabilir, izlenebilir ve dağıtılabilir yapıya sahip olmalıdır..
Microservice tek başına tek sorumluluğu olan ve tek iş yapan sadece o işe ait işleri yürüten modüler projelerdir.


Microservice mimarisi, tek bir uygulama geliştirirken modüler bir yapıda her biri küçük servis olarak düşünülmesi gereken ve her bir servisinde kendi işini ve 
iletişimini yürütebilen, çok karmaşık olmayan ve başka servislere bağımlılığı az olan mekanizmalara sahip bir yaklaşımdır. Bu servisler kendilerinin sorumlu olduğu 
tek bir işe odaklı ve bağımsız çalışabilen, otomatize bir deployment mekanizmasına sahip bir yapıdadır. Merkezi yönetim mekanizmalarından oldukça arındırılmış olmalıdır.
Farklı programlama dillerinde geliştirilebilir ve farklı veri tabanı teknolojileri kullanılabilir.

# API Gateway
Son yıllarda duymaya alıştığımız internet of 
things(nesnelerin interneti) olayının artması üzerine,
kullanılan API’ların yönetiminden doğan zorluklara karşı 
Amazon Web Service tarafından getirilen çözümdür.

Clientlar bu API üzerinden güvenlik ve yetkilendirme 
kontrollerinden geçerler ve hedefteki microservice’i API
Gateway aracılığıyla tetikleyerek sonuç alırlar.

API Gateway’in temel işlevi clienttan isteği alıp uygun servise iletmesidir.

# Ocelot 
Microservice yapılanmasını benimseyen uygulamalarda clientlardan gelen istekleri işlevsel açıdan uygun servislere yönlendirmekten sorumlu bir geçiş görevi gören 
API Gateway kütüphanesidir. Ocelot, clienttan gelen istek neticesinde oluşturulan HttpRequest nesnesini arkaplandaki servislere iletebilmek için HttpRequestMessage 
nesnesi oluşturmakta ve bu şekilde ulaştırmakla görevli middleware’dir. Ocelot, uygulamanın pipeline’ında ki son ara katmandır diyebiliriz ve bu yüzden bir sonraki 
middleware çağrılmamaktadır.
