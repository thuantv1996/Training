#include<stdio.h>
struct HOCSINH {
	char* HoTen;
	int DiemToan;
	int DiemVan;
};

int TinhDiemTrungBinh(HOCSINH hocsinh) {
	return (hocsinh.DiemToan + hocsinh.DiemVan) / 2;
}

class HOCSINH2 {
protected:
	char* HoTen;
	int DiemToan;
	int DiemVan;
public:
	void setDiemToan(int _diemToan) 
	{
		DiemToan = _diemToan;
	}

	void setDiemVan(int _diemVan)
	{
		DiemVan = _diemVan;
	}

	int LayDiemTrungBinh() 
	{
		return (this->DiemToan + this->DiemVan) / 2;
	}
};

// Main method
void main() {
	// Khoi tao doi tuong struct
	HOCSINH2 HocSinh;
	HocSinh.setDiemToan(5);
	HocSinh.setDiemVan(8);
	// menthod
	int dtb = HocSinh.LayDiemTrungBinh();
	return;
}

