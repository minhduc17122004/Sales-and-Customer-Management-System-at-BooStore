import random
from faker import Faker
from datetime import timedelta 

# Khởi tạo Faker và cấu hình Việt Nam
fake = Faker('vi_VN')

# Hàm tạo ngày ngẫu nhiên trong khoảng thời gian cho trước
def random_date(start_date, end_date):
    return start_date + timedelta(days=random.randint(0, (end_date - start_date).days))

def generate_vietnam_phone_number():
    # Danh sách các đầu số cho từng nhà mạng
    viettel = ['096', '097', '098', '086']
    vinaphone = ['088', '091', '094', '081', '082', '083', '084', '085']
    mobifone = ['090', '093', '089', '070', '079', '077', '078']
    
    # Chọn ngẫu nhiên một nhà mạng và ghép với 7 chữ số random
    all_networks = viettel + vinaphone + mobifone
    prefix = random.choice(all_networks)
    suffix = ''.join([str(random.randint(0, 9)) for _ in range(7)])
    
    return prefix + suffix
ten_duong_vn = [
    "Nguyễn Huệ", "Lê Lợi", "Trần Hưng Đạo", "Phạm Ngũ Lão", "Hai Bà Trưng", 
    "Ngô Quyền", "Bạch Đằng", "Lý Thường Kiệt", "Nguyễn Trãi", "Lê Văn Sỹ", 
    "Hoàng Diệu", "Đinh Tiên Hoàng", "Phan Đình Phùng", "Trường Chinh", 
    "Cách Mạng Tháng 8", "Điện Biên Phủ", "Lê Duẩn", "Nguyễn Thị Minh Khai", 
    "Hoàng Sa", "Trường Sa", "Tôn Đức Thắng", "Tô Hiến Thành", "Võ Thị Sáu", 
    "Lý Tự Trọng", "Nguyễn Văn Trỗi", "Pasteur", "Đồng Khởi", "Hàm Nghi", 
    "Bùi Thị Xuân", "Nam Kỳ Khởi Nghĩa", "Duy Tân", "Phan Xích Long", 
    "Nguyễn Đình Chiểu", "Ký Con", "Mạc Đĩnh Chi", "Phạm Văn Đồng", 
    "Nguyễn Chí Thanh", "Trần Phú", "Nguyễn Du", "Võ Văn Kiệt", 
    "Hùng Vương", "Huỳnh Tấn Phát", "Đỗ Xuân Hợp", "Lê Hồng Phong", 
    "Phan Văn Trị", "Lê Đại Hành", "Phan Chu Trinh", "Nguyễn Văn Linh", 
    "Võ Nguyên Giáp", "Nguyễn Tất Thành", "Đặng Văn Ngữ", "Tân Sơn Nhì", 
    "Thống Nhất", "Phạm Hùng", "Bà Huyện Thanh Quan", "Trần Khắc Chân", 
    "Nguyễn Bỉnh Khiêm", "Bùi Viện", "Đào Duy Từ", "Hồ Hảo Hớn", 
    "Võ Trường Toản", "Hòa Bình", "Tôn Thất Tùng", "Nguyễn Xí", 
    "Nguyễn Hữu Cảnh", "Phạm Thế Hiển", "Hoàng Hoa Thám", "Nguyễn Thái Học", 
    "Tôn Thất Thuyết", "Cộng Hòa", "Trần Quốc Toản", "Nguyễn Hữu Thọ", 
    "Đoàn Văn Bơ", "Nguyễn Văn Cừ", "Bạch Mai", "Đê La Thành", "Chùa Bộc", 
    "Hoàng Quốc Việt", "Giải Phóng", "Kim Mã", "Xuân Thủy", "Trần Duy Hưng", 
    "Vạn Phúc", "Phạm Văn Bạch", "Nguyễn Khánh Toàn", "Nguyễn Công Trứ", 
    "Phố Huế", "Tràng Tiền", "Láng Hạ", "Thái Hà", "Lê Trọng Tấn", 
    "Phùng Hưng", "Đặng Thai Mai", "Hoàng Văn Thụ", "Nguyễn Oanh", 
    "Cao Thắng", "Hải Triều", "Đồng Đen", "Hoàng Sa", "Trần Văn Đang"
]

thanh_pho_quan_huyen_phuong = {
    "Thành phố Hà Nội": {
        "Quận Ba Đình": ["Phường Trúc Bạch", "Phường Điện Biên", "Phường Ngọc Hà", "Phường Kim Mã"],
        "Quận Hoàn Kiếm": ["Phường Hàng Bạc", "Phường Hàng Đào", "Phường Chương Dương", "Phường Phan Chu Trinh"],
        "Quận Đống Đa": ["Phường Kim Liên", "Phường Trung Tự", "Phường Đống Đa", "Phường Ngã Tư Sở"],
        "Quận Hai Bà Trưng": ["Phường Bạch Đằng", "Phường Đồng Nhân", "Phường Lê Đại Hành", "Phường Minh Khai"],
        "Quận Hoàng Mai": ["Phường Hoàng Văn Thụ", "Phường Mai Động", "Phường Định Công", "Phường Lĩnh Nam"],
        "Quận Long Biên": ["Phường Gia Thụy", "Phường Ngọc Thụy", "Phường Việt Hưng", "Phường Bồ Đề"],
        "Quận Tây Hồ": ["Phường Quảng An", "Phường Nhật Tân", "Phường Tứ Liên", "Phường Xuân La"],
        "Quận Nam Từ Liêm": ["Phường Mỹ Đình 1", "Phường Mỹ Đình 2", "Phường Phú Đô", "Phường Mễ Trì"],
        "Quận Bắc Từ Liêm": ["Phường Thụy Phương", "Phường Minh Khai", "Phường Phú Diễn", "Phường Tây Tựu"],
        "Huyện Đông Anh": ["Xã Bắc Hồng", "Xã Xuân Nộn", "Xã Võng La", "Xã Nguyên Khê"]
    },
    "Thành phố Hồ Chí Minh": {
        "Quận 1": ["Phường Bến Nghé", "Phường Bến Thành", "Phường Cầu Ông Lãnh", "Phường Nguyễn Thái Bình"],
        "Quận 2": ["Phường An Khánh", "Phường An Lợi Đông", "Phường Thủ Thiêm", "Phường Bình Khánh"],
        "Quận 3": ["Phường Võ Thị Sáu", "Phường 6", "Phường 7", "Phường 9"],
        "Quận 4": ["Phường 1", "Phường 3", "Phường 5", "Phường 6"],
        "Quận 5": ["Phường 1", "Phường 5", "Phường 7", "Phường 8"],
        "Quận 6": ["Phường 1", "Phường 2", "Phường 3", "Phường 10"],
        "Quận 7": ["Phường Tân Quy", "Phường Tân Phú", "Phường Bình Thuận", "Phường Phú Mỹ"],
        "Quận 8": ["Phường 1", "Phường 2", "Phường 3", "Phường 4"],
        "Quận 9": ["Phường Hiệp Phú", "Phường Long Bình", "Phường Tân Phú", "Phường Phú Hữu"],
        "Quận Thủ Đức": ["Phường Linh Chiểu", "Phường Bình Thọ", "Phường Tam Bình", "Phường Tam Phú"]
    },
    "Thành phố Đà Nẵng": {
        "Quận Hải Châu": ["Phường Hải Châu 1", "Phường Hải Châu 2", "Phường Thạch Thang", "Phường Phước Ninh"],
        "Quận Thanh Khê": ["Phường Thanh Khê Đông", "Phường Thanh Khê Tây", "Phường An Khê", "Phường Hòa Khê"],
        "Quận Sơn Trà": ["Phường Thọ Quang", "Phường Mân Thái", "Phường An Hải Bắc", "Phường An Hải Đông"],
        "Quận Ngũ Hành Sơn": ["Phường Mỹ An", "Phường Khuê Mỹ", "Phường Hòa Hải", "Phường Hòa Quý"],
        "Quận Liên Chiểu": ["Phường Hòa Minh", "Phường Liên Chiểu", "Phường Xuân Thiều", "Phường Thanh Khê Tây"],
        "Huyện Hòa Vang": ["Xã Hòa Khương", "Xã Hòa Phước", "Xã Hòa Tiến", "Xã Hòa Sơn"],
        "Huyện đảo Hoàng Sa": ["Xã đảo Hoàng Sa"]
    },
    "Thành phố Hải Phòng": {
        "Quận Hồng Bàng": ["Phường Sở Dầu", "Phường Quán Toan", "Phường Phan Bội Châu", "Phường Thượng Lý"],
        "Quận Ngô Quyền": ["Phường Máy Tơ", "Phường Đằng Lâm", "Phường Lê Lợi", "Phường Trần Nguyên Hãn"],
        "Quận Lê Chân": ["Phường An Biên", "Phường An Dương", "Phường Dư Hàng Kênh", "Phường Dư Hàng"],
        "Quận Kiến An": ["Phường Bắc Sơn", "Phường Kiến An", "Phường Tràng Minh", "Phường Đồng Hòa"],
        "Quận Đồ Sơn": ["Phường Vạn Hương", "Phường Vạn Sơn", "Phường Đồ Sơn", "Phường Ngọc Hải"],
        "Huyện An Dương": ["Xã An Hưng", "Xã An Lão", "Xã An Thắng", "Xã An Sơn"],
        "Huyện Thủy Nguyên": ["Xã Thủy Sơn", "Xã Thủy Đường", "Xã Thủy Nguyên", "Xã Lý Học"]
    },
    "Thành phố Cần Thơ": {
        "Quận Ninh Kiều": ["Phường An Hội", "Phường Cái Khế", "Phường Tân An", "Phường Hưng Lợi"],
        "Quận Bình Thủy": ["Phường Bình Thủy", "Phường Thới Bình", "Phường Trà Nóc", "Phường An Thới"],
        "Quận Cái Răng": ["Phường Lê Bình", "Phường Hưng Phú", "Phường Phú Thứ", "Phường Thường Thạnh"],
        "Quận Ô Môn": ["Phường Thới An", "Phường Trường Lạc", "Phường Phước Thới", "Phường Châu Văn Liêm"],
        "Quận Thốt Nốt": ["Phường Thốt Nốt", "Phường Tân Thới", "Phường Thường Thạnh", "Phường Trung Nhứt"],
        "Huyện Vĩnh Thạnh": ["Xã Vĩnh Trinh", "Xã Vĩnh Thạnh", "Xã Vĩnh Lộc", "Xã Thạnh Mỹ"],
        "Huyện Cờ Đỏ": ["Xã Thới Hưng", "Xã Đông Hiệp", "Xã Cờ Đỏ", "Xã Thới Xuân"]
    },
    "Thành phố Nha Trang": {
        "Thành phố Nha Trang": ["Phường Vĩnh Hòa", "Phường Vĩnh Nguyên", "Phường Vĩnh Trường", "Phường Xương Huân"],
        "Huyện Diên Khánh": ["Thị trấn Diên Khánh", "Xã Diên Thọ", "Xã Diên Phước", "Xã Diên Lạc"],
        "Huyện Vạn Ninh": ["Thị trấn Vạn Giã", "Xã Vạn Phước", "Xã Vạn Khánh", "Xã Vạn Lương"],
        "Huyện Cam Lâm": ["Thị trấn Cam Đức", "Xã Cam Tân", "Xã Cam Hòa", "Xã Cam Hải Đông"],
        "Huyện Khánh Sơn": ["Thị trấn Tô Hạp", "Xã Sơn Trung", "Xã Sơn Bình", "Xã Sơn Lâm"],
        "Huyện Khánh Vĩnh": ["Xã Khánh Vĩnh", "Xã Liên Sang", "Xã Khánh Hiệp", "Xã Khánh Phú"],
        "Huyện Trường Sa": ["Xã Sinh Tồn", "Xã Song Tử Tây", "Xã Đá Lớn", "Xã Trường Sa"]
    },
    "Thành phố Biên Hòa": {
        "Thành phố Biên Hòa": ["Phường Bình Đa", "Phường An Bình", "Phường Tân Mai", "Phường Quang Vinh"],
        "Huyện Nhơn Trạch": ["Thị trấn Hiệp Phước", "Xã Phú Hữu", "Xã Vĩnh Thanh", "Xã Nhơn Trạch"],
        "Huyện Long Thành": ["Thị trấn Long Thành", "Xã Bình Sơn", "Xã Bàu Hàm", "Xã Tam An"],
        "Huyện Vĩnh Cửu": ["Xã Vĩnh Tân", "Xã Vĩnh An", "Xã Vĩnh Cửu", "Xã Vĩnh Thanh"],
        "Huyện Trảng Bom": ["Thị trấn Trảng Bom", "Xã Thanh Bình", "Xã Đồi 61", "Xã An Viễn"],
        "Huyện Tân Phú": ["Thị trấn Tân Phú", "Xã Phú Điền", "Xã Tân Hòa", "Xã Tân Hưng"],
        "Huyện Định Quán": ["Thị trấn Định Quán"]
    },
    "Thành phố Vũng Tàu": {
        "Thành phố Vũng Tàu": ["Phường 1", "Phường 2", "Phường 3", "Phường 4"],
        "Huyện Bà Rịa": ["Xã Long Tân", "Xã Tân Hòa", "Xã Phước Tỉnh", "Xã Hòa Long"],
        "Huyện Long Điền": ["Thị trấn Long Điền", "Xã Phước Hải", "Xã An Ngãi", "Xã Long Hải"],
        "Huyện Đất Đỏ": ["Thị trấn Đất Đỏ", "Xã Phước Long", "Xã Long Mỹ", "Xã Lộc An"],
        "Huyện Xuyên Mộc": ["Thị trấn Phước Bửu", "Xã Bưng Riềng", "Xã Lộc An", "Xã Phước Tân"],
        "Huyện Châu Đức": ["Thị trấn Ngãi Giao", "Xã Bông Trang", "Xã Nghĩa Thành", "Xã Suối Nghệ"],
        "Huyện Côn Đảo": ["Thị trấn Côn Đảo"]
    },
    "Thành phố Thủ Dầu Một": {
        "Thành phố Thủ Dầu Một": ["Phường Phú Hòa", "Phường Phú Mỹ", "Phường Hiệp Thành", "Phường Chánh Nghĩa"],
        "Huyện Bến Cát": ["Thị trấn Bến Cát", "Xã An Điền", "Xã An Tây", "Xã Tân Định"],
        "Huyện Dầu Tiếng": ["Thị trấn Dầu Tiếng", "Xã Định Thành", "Xã Định An", "Xã Thanh Tuyền"],
        "Huyện Tân Uyên": ["Thị trấn Tân Uyên", "Xã Khánh Bình", "Xã Tân Hiệp", "Xã Vĩnh Tân"],
        "Huyện Phú Giáo": ["Thị trấn Phước Vĩnh", "Xã Phú Mỹ", "Xã Tân Hiệp", "Xã Tân Long"],
        "Huyện Bắc Tân Uyên": ["Thị trấn Tân Thành", "Xã Đất Cuốc", "Xã Bàu Bàng", "Xã Tân Lập"],
        "Huyện Bàu Bàng": ["Thị trấn Bàu Bàng"]
    },
    "Thành phố Huế": {
        "Thành phố Huế": ["Phường Vỹ Dạ", "Phường Phú Nhuận", "Phường Thủy Biều", "Phường An Cựu"],
        "Huyện Phú Vang": ["Xã Phú Hải", "Xã Phú Đa", "Xã Vinh Thanh", "Xã Phú Thượng"],
        "Huyện Phú Lộc": ["Xã Lộc Tiến", "Xã Lộc Vĩnh", "Xã Lộc Hòa", "Xã Lộc Thủy"],
        "Huyện Quảng Điền": ["Xã Quảng An", "Xã Quảng Thành", "Xã Quảng Phú", "Xã Quảng Điền"],
        "Huyện Hương Thủy": ["Xã Thủy Bằng", "Xã Thủy Vân", "Xã Thủy Xuân", "Xã Thủy Phương"],
        "Huyện Hương Trà": ["Xã Hương An", "Xã Hương Vinh", "Xã Hương Xuân", "Xã Hương Thọ"],
        "Huyện A Lưới": ["Xã Hương Lâm", "Xã Hương Phú", "Xã A Ngo", "Xã A Roàng"]
    }
}

# Module tạo dữ liệu cho bảng KHACH_HANG
def generate_data_khach_hang(num_customers=1000):
    data = []
    
    for i in range(num_customers):
        MaKH = f"KH{i:04d}"  # Mã khách hàng
        TenKH = fake.name()  # Tên khách hàng
        SoDienThoai = generate_vietnam_phone_number()  # Sử dụng hàm tạo số điện thoại hợp lệ

        # Chọn ngẫu nhiên một thành phố
        city = random.choice(list(thanh_pho_quan_huyen_phuong.keys()))
        
        # Chọn ngẫu nhiên một quận/huyện từ thành phố đã chọn
        district = random.choice(list(thanh_pho_quan_huyen_phuong[city].keys()))
        
        # Chọn ngẫu nhiên một phường/xã từ quận/huyện đã chọn
        ward = random.choice(thanh_pho_quan_huyen_phuong[city][district])
        
        # Chọn ngẫu nhiên một tên đường
        ten_duong = random.choice(ten_duong_vn)
        
        # Tạo địa chỉ
        DiaChi = f"{random.randint(1, 1000)} {ten_duong}, {ward}, {district}, {city}"
        
        # Thêm thông tin khách hàng vào danh sách
        data.append(f"('{MaKH}', N'{TenKH}', '{SoDienThoai}', N'{DiaChi}')")
    
    return data

# Module tạo dữ liệu cho bảng NHAN_VIEN_CSKH
def generate_data_nhan_vien():
    Chucvu = ["Bán hàng", "CSKH"]
    data = []
    for i in range(1000):
        MaNV = f"NV{i:04d}"
        TenNV = fake.name()
        SoDienThoaiNV = generate_vietnam_phone_number()  # Sử dụng hàm tạo số điện thoại hợp lệ
        ViTri = random.choice(Chucvu)
        data.append(f"('{MaNV}', N'{TenNV}', '{SoDienThoaiNV}', N'{ViTri}')")
    return data

# Module tạo dữ liệu cho bảng SAN_PHAM
def generate_data_san_pham():
    trending_clothes = [
        "Áo phông oversized", "Áo hoodie", "Áo khoác bomber", "Áo blazer", "Áo cardigan", 
        "Áo sơ mi form rộng", "Áo crop top", "Áo khoác dạ", "Áo len", "Áo thun basic", 
        "Áo khoác denim", "Áo polo", "Áo vest", "Áo len cổ lọ", "Áo khoác parka", 
        "Áo khoác da", "Áo khoác jean", "Áo blazer ngắn", "Áo khoác puffer", "Áo tank top",
        "Quần jean ống rộng", "Quần kaki", "Quần short jean", "Quần jogger", "Quần tây",
        "Quần âu", "Quần culottes", "Quần skinny jeans", "Quần short kaki", "Quần baggy",
        "Chân váy midi", "Chân váy xòe", "Chân váy jean", "Chân váy chữ A", "Chân váy bút chì",
        "Váy maxi", "Váy bodycon", "Váy xếp ly", "Váy slip dress", "Váy suông",
        "Đầm dạ hội", "Đầm ôm sát", "Đầm tay bồng", "Đầm xếp tầng", "Đầm maxi hoa",
        "Đầm cổ yếm", "Đầm công sở", "Jumpsuit dài", "Jumpsuit ngắn", "Set bộ thể thao",
        "Set vest nữ", "Set đồ dạo phố", "Bộ đồ thể thao", "Bộ đồ ngủ", "Set đồ công sở",
        "Set áo len và váy", "Set áo thun và quần jogger", "Set áo blazer và chân váy", "Set váy len và áo khoác",
        "Áo len oversize", "Áo thun graphic", "Áo khoác thể thao", "Áo khoác nỉ", "Quần jean rách gối",
        "Quần jean baggy", "Quần jean slim fit", "Quần short thể thao", "Quần short vải bố", "Quần short denim",
        "Chân váy mini", "Váy ôm sát", "Váy midi hoa", "Váy thun", "Đầm ôm body",
        "Váy yếm", "Váy suông tay phồng", "Váy đuôi cá", "Đầm cổ chữ V", "Đầm dạ tiệc",
        "Áo phông in hình", "Áo sơ mi dài tay", "Áo sơ mi lụa", "Áo sơ mi ngắn tay", "Áo phông có họa tiết",
        "Quần tây lửng", "Quần short jeans rách", "Váy xòe vintage", "Váy maxi ren", "Áo phao dài",
        "Set váy và áo thun", "Set bộ đùi và áo phông", "Set quần jeans và áo sơ mi", "Đầm tiệc lụa", "Áo khoác blazer",
        "Áo khoác cardigan dáng dài", "Set đầm maxi", "Đầm dạo phố", "Set áo và quần jeans", "Set áo khoác và váy ngắn"
    ]    
    data = []
    for i in range(1000):
        MaSP = f"SP{i:04d}"
        TenSP = random.choice(trending_clothes)
        SoLuong_SP = random.randint(0, 50)
        data.append(f"('{MaSP}', N'{TenSP}', {SoLuong_SP})")
    return data

# Module tạo dữ liệu cho bảng DON_VI_VAN_CHUYEN
import random

def generate_data_don_vi_van_chuyen(num_rows=1000):
    data = []
    
    # Danh sách thông tin 5 đơn vị vận chuyển cố định
    base_don_vi_van_chuyen = [
        "Giao Hàng Nhanh",
        "Vietnam Post",
        "Giao Hàng Tiết Kiệm",
        "Viettel Post",
        "J&T Express"
    ]
    
    # Tạo 1000 bản ghi dữ liệu ngẫu nhiên
    for i in range(num_rows):
        TenDV = random.choice(base_don_vi_van_chuyen)  # Chọn ngẫu nhiên 1 tên đơn vị vận chuyển
        
        # Tạo mã đơn vị vận chuyển ngẫu nhiên
        MaDVVC = f"DV{i+1:04d}"
        
        # Sinh số điện thoại ngẫu nhiên
        SoDienThoaiDV = generate_vietnam_phone_number()
        
                # Chọn ngẫu nhiên một thành phố
        city = random.choice(list(thanh_pho_quan_huyen_phuong.keys()))
        
        # Chọn ngẫu nhiên một quận/huyện từ thành phố đã chọn
        district = random.choice(list(thanh_pho_quan_huyen_phuong[city].keys()))
        
        # Chọn ngẫu nhiên một phường/xã từ quận/huyện đã chọn
        ward = random.choice(thanh_pho_quan_huyen_phuong[city][district])
        
        # Chọn ngẫu nhiên một tên đường
        ten_duong = random.choice(ten_duong_vn)
        
        # Tạo địa chỉ
        DiaChiDV = f"{random.randint(1, 1000)} {ten_duong}, {ward}, {district}, {city}"
        
        # Thêm thông tin vào danh sách dữ liệu
        data.append(f"('{MaDVVC}', N'{TenDV}', '{SoDienThoaiDV}', N'{DiaChiDV}')")
    
    return data


# Module tạo dữ liệu cho bảng GIA_THANH
def generate_data_gia_thanh(san_pham_data):
    data = []
    for sp in san_pham_data:
        MaSP = sp.split(",")[0].strip("('")  # Lấy mã sản phẩm từ dữ liệu của bảng SAN_PHAM
        MaGia = f"GIA{int(MaSP[2:]):04d}"  # Tạo mã giá tương ứng với mã sản phẩm
        NgayApDung = fake.date_between(start_date='-1y', end_date='today')
        NgayKetThuc = fake.date_between(start_date=NgayApDung, end_date='+1y')
        GiaBan = round(random.uniform(50000, 1000000), 0)  # Random giá bán từ 50,000 đến 1,000,000
        data.append(f"('{MaGia}', '{MaSP}', {GiaBan},'{NgayApDung}', '{NgayKetThuc}' )")
    return data

# Module tạo dữ liệu cho bảng DON_HANG
def generate_data_don_hang():
    data = []
    for i in range(1000):
        MaDH = f"DH{i:04d}"
        MaKH = f"KH{random.randint(0, 999):04d}"
        NgayMua = fake.date_between(start_date='-2y', end_date='today')
        TongTien = round(random.uniform(50000, 5000000), 2)
        LoaiDH = random.choice(['0', '1'])  # 0 là mua tại cửa hàng, 1 là mua trực tuyến
        MaNV = f"NV{i:04d}"
        data.append(f"('{MaDH}', '{MaKH}', '{NgayMua}', {TongTien}, '{LoaiDH}', '{MaNV}')")
    return data

# Module tạo dữ liệu cho bảng SHIP
def generate_data_ship():
    data = []
    for i in range(1000):
        MaShip = f"MS{i:04d}"
        MaDH = f"DH{i:04d}"
        MaDVVC = f"DV{random.randint(0, 99):04d}"
        PhiShip = round(random.uniform(15000, 50000), 0)
        TrangThaiGiaoHang = random.choice(['0', '1', '2', '3', '4'])
        NgayGiao = fake.date_between(start_date='-1y', end_date='today')
        data.append(f"('{MaShip}', '{MaDH}', '{MaDVVC}', {PhiShip}, '{TrangThaiGiaoHang}', '{NgayGiao}')")
    return data


# Module tạo dữ liệu cho bảng CHI_TIET_DON_HANG
def generate_data_chi_tiet_don_hang(don_hang_data, gia_thanh_data):
    data = []
    
    for dh in don_hang_data:
        MaDH = dh.split(",")[0].strip("('")  # Lấy mã đơn hàng từ dữ liệu của bảng DON_HANG
        
        # Tạo ít nhất một sản phẩm cho mỗi đơn hàng từ bảng GIA_THANH
        for _ in range(random.randint(1, 5)):  # Mỗi đơn hàng có thể có từ 1 đến 5 sản phẩm
            gia_thanh_record = random.choice(gia_thanh_data)
            MaGia = gia_thanh_record.split(",")[0].strip("('")  # Mã giá
            MaSP = gia_thanh_record.split(",")[1].strip(" '")  # Mã sản phẩm
            SoLuong = random.randint(1, 10)  # Số lượng sản phẩm cho đơn hàng
            data.append(f"('{MaDH}', '{MaSP}', '{MaGia}', {SoLuong})")
    
    return data

# Module tạo dữ liệu cho bảng PHIEU_KHIEU_NAI
def generate_data_phieu_khieu_nai():
    data = []
    for i in range(1000):
        MaKN = f"KN{i:04d}"
        MaKH = f"KH{random.randint(0, 999):04d}"
        MaDH = f"DH{random.randint(0, 999):04d}"
        NgayKN = fake.date_between(start_date='-1y', end_date='today')
        LoaiKN = random.choice(['1', '2', '3'])
        TrangThaiKN = random.choice(['0', '1'])  # 0 chưa giải quyết, 1 đã giải quyết
        data.append(f"('{MaKN}', '{MaKH}', '{MaDH}', '{NgayKN}', '{LoaiKN}', '{TrangThaiKN}')")
    return data


# Module tạo dữ liệu cho bảng CHI_TIET_KHIEU_NAI với ngày giải quyết trong vòng 5 ngày kể từ ngày khiếu nại
def generate_data_chi_tiet_khieu_nai():
    van_de_options = [
        'Chất lượng sản phẩm', 'Giao hàng chậm', 'Dịch vụ kém', 
        'Thái độ của nhân viên', 'Hàng không giống mô tả', 'Sản phẩm bị lỗi', 
        'Đóng gói sản phẩm không cẩn thận', 'Nhân viên không hỗ trợ khách hàng tốt', 
        'Sai màu/sai size', 'Sản phẩm bị hỏng khi đến nơi', 'Thời gian giao hàng không đúng hẹn',
        'Không có ai liên hệ khi sản phẩm gặp sự cố', 'Quy trình đổi trả phức tạp', 
        'Phí giao hàng quá cao', 'Hàng bị thiếu trong đơn hàng', 
        'Giao sai sản phẩm', 'Nhân viên giao hàng không lịch sự', 
        'Không chấp nhận đổi trả', 'Không hỗ trợ trả góp', 'Chính sách bảo hành không rõ ràng'
    ]
    
    phuong_an_options = [
        'Hoàn tiền 100%', 'Đổi sản phẩm mới', 'Bù sản phẩm', 'Giảm giá lần mua tiếp theo', 
        'Tặng phiếu mua hàng', 'Gọi lại cho khách hàng', 'Hỗ trợ đổi trả', 
        'Miễn phí giao hàng đơn tiếp theo', 'Hỗ trợ kỹ thuật', 'Giải thích chính sách rõ ràng hơn', 
        'Tăng cường đào tạo nhân viên', 'Kiểm tra sản phẩm cẩn thận hơn', 'Cung cấp mã giảm giá', 
        'Liên hệ khách hàng xác nhận thông tin', 'Nhân viên giao hàng lịch sự hơn', 
        'Cung cấp thêm kênh hỗ trợ khách hàng', 'Thay đổi quy trình đổi trả', 
        'Giảm giá phí vận chuyển cho đơn tiếp theo', 'Giao hàng nhanh hơn', 'Cải thiện chất lượng sản phẩm'
    ]
    
    data = []
    for i in range(1000):
        MaKN = f"KN{i:04d}"
        MaNV = f"NV{random.randint(0, 999):04d}"
        VanDe = random.choice(van_de_options)
        PhuongAn = random.choice(phuong_an_options)
        NgayGiaiQuyet = fake.date_between(start_date='-1y', end_date='today')
        data.append(f"('{MaKN}', '{MaNV}', N'{VanDe}', N'{PhuongAn}', '{NgayGiaiQuyet}')")
    return data


# Hàm xuất dữ liệu ra file SQL
def export_sql_file(table_name, data):
    with open(f'{table_name}_dump.sql', 'w', encoding='utf-8') as f:
        for row in data:
            f.write(f"INSERT INTO {table_name} VALUES {row};\n")

# Gọi hàm tạo dữ liệu và xuất ra file SQL
khach_hang_data = generate_data_khach_hang()
export_sql_file('KHACH_HANG', khach_hang_data)

nhan_vien_data = generate_data_nhan_vien()
export_sql_file('NHAN_VIEN', nhan_vien_data)

san_pham_data = generate_data_san_pham()
export_sql_file('SAN_PHAM', san_pham_data)

don_vi_van_chuyen_data = generate_data_don_vi_van_chuyen()
export_sql_file('DON_VI_VAN_CHUYEN', don_vi_van_chuyen_data)

gia_thanh_data = generate_data_gia_thanh(san_pham_data)
export_sql_file('GIA_THANH', gia_thanh_data)

don_hang_data = generate_data_don_hang()
export_sql_file('DON_HANG', don_hang_data)

# Gọi hàm tạo dữ liệu và xuất ra file SQL cho các bảng còn lại

# Bảng SHIP
ship_data = generate_data_ship()
export_sql_file('SHIP', ship_data)


# Bảng CHI_TIET_DON_HANG
chi_tiet_don_hang_data = generate_data_chi_tiet_don_hang(don_hang_data,gia_thanh_data)
export_sql_file('CHI_TIET_DON_HANG', chi_tiet_don_hang_data)

# Bảng PHIEU_KHIEU_NAI
phieu_khieu_nai_data = generate_data_phieu_khieu_nai()
export_sql_file('PHIEU_KHIEU_NAI', phieu_khieu_nai_data)

# Bảng CHI_TIET_KHIEU_NAI
chi_tiet_khieu_nai_data = generate_data_chi_tiet_khieu_nai()
export_sql_file('CHI_TIET_KHIEU_NAI', chi_tiet_khieu_nai_data)

print("Hoàn thành!")


