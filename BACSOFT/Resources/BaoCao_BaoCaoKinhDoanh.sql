SET DATEFORMAT DMY
DECLARE @TuNgay AS Datetime
DECLARE @DenNgay AS Datetime
DECLARE @TuNgayDK AS Datetime
DECLARE @DenNgayDK AS Datetime
SET @TuNgay= '{@TuNgay}'
SET @DenNgay= '{@DenNgay}'


DECLARE @tbKHTheoThang AS table
(	
	IDKhachHang int,
	IDTakeCare int,
	Thang Datetime,
	Loai Nvarchar(2),
	KHMoi bit
)


DECLARE @tbTieuChi AS table
(
	STT tinyint,
	IDTieuChi  int,
	NoiDung  nvarchar(250)
)

INSERT INTO @tbTieuChi (STT,IDTieuChi,NoiDung)
SELECT 1,1, N'KH: Mới _ Tổng'
union
SELECT 2,8, N'YC: SL/Số KH' 
union
SELECT 3,2, N'CG: SL/Số KH.tổng _ Số tiền'
union
SELECT 4,3, N'CG: SL/Số KH.mới _ Số tiền'  
union
SELECT 5,4, N'XN: SL/Số KH.tổng _ Số tiền' 
union 
SELECT 6,5, N'XN: SL/Số KH.mới _ Số tiền' 
union
SELECT 7,6, N'XK: SL/Số KH.tổng _ Số tiền' 
union
SELECT 8,7, N'XK: SL/Số KH.mới _ Số tiền' 


INSERT INTO @tbKHTheoThang
SELECT DISTINCT IDKhachHang,IDTakeCare,Ngay,Loai,KHMoi
FROM (
select IDKhachHang,IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)) Ngay,N'CG' AS Loai,
(CASE WHEN 
	(SELECT count( IDKhachHang) FROM BANGCHAOGIA AS B WHERE B.IDKhachHang=BANGCHAOGIA.IDKhachHang AND
			datediff(day,B.NgayNhan,BANGCHAOGIA.NgayNhan)<365 AND  BANGCHAOGIA.NgayNhan > B.NgayNhan 
			AND RIGHT(CONVERT(nvarchar, B.NgayNhan,103),7) <> RIGHT(CONVERT(nvarchar, BANGCHAOGIA.NgayNhan,103),7) AND B.TrangThai=2
		) >0
		THEN 0
		ELSE 1
END) As KHMoi
FROM BANGCHAOGIA 
WHERE TrangThai=2
AND CONVERT(Datetime,Convert(Nvarchar,NgayNhan,103),103) BETWEEN @TuNgay AND @DenNgay
UNION ALL
select IDKhachHang,IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,N'XK' AS Loai,
(CASE WHEN 
	(SELECT count( IDKhachHang) FROM PHIEUXUATKHO tbXK
	WHERE tbXK.IDKhachHang=PHIEUXUATKHO.IDKhachHang AND CONVERT(Datetime,Convert(Nvarchar,tbXK.NGAYTHANG,103),103) 
	BETWEEN
		Dateadd(year,-1,DATEADD(mm, DATEDIFF(m,0,PHIEUXUATKHO.NGAYTHANG),0))  
	AND DATEADD(mm, DATEDIFF(m,0,PHIEUXUATKHO.NGAYTHANG),0) 
		) >0
		THEN 0
		ELSE 1
END)KHMoi
FROM PHIEUXUATKHO 
WHERE CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay)tb
order by Ngay,IDKhachHang

DECLARE @tbtmp table
(
	ID	int,
	Ten nvarchar(250),
	IDDepatment int,
	STT tinyint,
	IDTieuChi int,
	NoiDung nvarchar(250),
	SoLuong	nvarchar(50),
	SoLuong1 int,
	SoLuong2 int,
	SoTien float,
	Ngay datetime
)

INSERT INTO @tbtmp
SELECT DISTINCT ID,Ten,IDDepatment,[@tbTieuChi].STT,[@tbTieuChi].IDTieuChi,[@tbTieuChi].NoiDung,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		Convert(nvarchar,tbKH.SoKHmoi)
	WHEN 2 THEN
        tbSoCG.SoLuong
	WHEN 3 THEN
		tbSoCGMoi.SoLuong
	WHEN 4 THEN
        tbSoCGXN.SoLuong
	WHEN 5 THEN
        tbSoCGXNMoi.SoLuong
	WHEN 6 THEN
		tbSoXK.SoLuong
	WHEN 7 THEN
		tbSoXKMoi.SoLuong
	WHEN 8 THEN
		tbSoYC.SoLuong
END) AS SoLuong,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		Convert(nvarchar,tbKH.SoKHmoi)
	WHEN 2 THEN
        tbSoCG.SoLuong1
	WHEN 3 THEN
		tbSoCGMoi.SoLuong1
	WHEN 4 THEN
        tbSoCGXN.SoLuong1
	WHEN 5 THEN
        tbSoCGXNMoi.SoLuong1
	WHEN 6 THEN
		tbSoXK.SoLuong1
	WHEN 7 THEN
		tbSoXKMoi.SoLuong1
	WHEN 8 THEN
		tbSoYC.SoLuong1
END) AS SoLuong1,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		Convert(nvarchar,tbKH.SoKHmoi)
	WHEN 2 THEN
        tbSoCG.SoLuong2
	WHEN 3 THEN
		tbSoCGMoi.SoLuong2
	WHEN 4 THEN
        tbSoCGXN.SoLuong2
	WHEN 5 THEN
        tbSoCGXNMoi.SoLuong2
	WHEN 6 THEN
		tbSoXK.SoLuong2
	WHEN 7 THEN
		tbSoXKMoi.SoLuong2
	WHEN 8 THEN
		tbSoYC.SoLuong2
END) AS SoLuong2,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		Convert(nvarchar,tbKH.SoKH)
	WHEN 2 THEN
        tbSoCG.SoTien
	WHEN 3 THEN
		tbSoCGMoi.SoTien
	WHEN 4 THEN
        tbSoCGXN.SoTien
	WHEN 5 THEN
        tbSoCGXNMoi.SoTien
	WHEN 6 THEN
		tbSoXK.SoTien
	WHEN 7 THEN
		tbSoXKMoi.SoTien
	WHEN 8 THEN
		tbSoYC.SoTien
END) AS SoTien,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		tbKH.Thang
	WHEN 2 THEN
        tbSoCG.Ngay
	WHEN 3 THEN
		tbSoCGMoi.Ngay
	WHEN 4 THEN
        tbSoCGXN.Ngay 
	WHEN 5 THEN
        tbSoCGXNMoi.Ngay
	WHEN 6 THEN
		tbSoXK.Ngay
	WHEN 7 THEN
		tbSoXKMoi.Ngay
	WHEN 8 THEN
		tbSoYC.Ngay
END) AS Ngay

FROM NHANSU
CROSS JOIN @tbTieuChi
LEFT JOIN 

(SELECT sum((CASE WHEN KHMoi=1 THEN 1 ELSE 0 END))SoKHMoi,  Count(IDKhachHang)SoKH,  IDTakeCare,Thang 
FROM @tbKHTheoThang
GROUP BY IDTakeCare,Thang)tbKH ON NHANSU.ID=tbKH.IDTakeCare

LEFT JOIN
------ Tổng số YC/Số KH của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, 0 as SoTien
FROM BANGYEUCAU 
WHERE  CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay 
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)))tbSoYC ON tbSoYC.IDTakeCare=NHANSU.ID

LEFT JOIN
------ Tổng số CG/Số KH của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, SUM(TienTruocThue)SoTien
FROM BANGCHAOGIA 
WHERE  CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay 
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)))tbSoCG ON tbSoCG.IDTakeCare=NHANSU.ID
LEFT JOIN
------ Tổng số CG/Số KH mới của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, SUM(TienTruocThue)SoTien
FROM BANGCHAOGIA 
WHERE  CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay
AND IDKhachHang IN (SELECT IDKhachHang FROM @tbKHTheoThang WHERE [@tbKHTheoThang].KHMoi=1 AND [@tbKHTheoThang].Loai=N'CG' AND [@tbKHTheoThang].IDTakeCare=BANGCHAOGIA.IDTakeCare AND
				 [@tbKHTheoThang].Thang =DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) )
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)))tbSoCGMoi ON tbSoCGMoi.IDTakecare=NHANSU.ID
LEFT JOIN
-----  Tổng số CG/Số KH đã xác nhận của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, SUM(TienTruocThue)SoTien
FROM BANGCHAOGIA 
WHERE TrangThai=2 AND CONVERT(Datetime,Convert(Nvarchar,NgayNhan,103),103) BETWEEN @TuNgay AND @DenNgay 
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)))tbSoCGXN ON tbSoCGXN.IDTakecare=NHANSU.ID
LEFT JOIN
-----  Tổng số CG/Số KH mới đã xác nhận của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, SUM(TienTruocThue)SoTien
FROM BANGCHAOGIA 
WHERE TRangThai=2 AND CONVERT(Datetime,Convert(Nvarchar,NgayNhan,103),103) BETWEEN @TuNgay AND @DenNgay
AND IDKhachHang IN (SELECT IDKhachHang FROM @tbKHTheoThang WHERE [@tbKHTheoThang].KHMoi=1 AND [@tbKHTheoThang].Loai=N'CG' AND [@tbKHTheoThang].IDTakeCare=BANGCHAOGIA.IDTakeCare AND
				 [@tbKHTheoThang].Thang =DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)) )
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NgayNhan)+1,0)))tbSoCGXNMoi ON tbSoCGXNMoi.IDTakecare=NHANSU.ID
LEFT JOIN
-----  Tổng số XK/Số KH của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong, COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2,SUM(TienTruocThue)SoTien
FROM PHIEUXUATKHO 
WHERE CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay 
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)))tbSoXK ON tbSoXK.IDTakecare=NHANSU.ID
LEFT JOIN
-----  Tổng số XK/Số KH mới của từng nhân viên theo từng tháng
(select IDTakeCare, DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) Ngay,
	ltrim( COUNT(SoPhieu))+ '/' + ltrim(count( DISTINCT IDKhachHang))SoLuong,COUNT(SoPhieu) AS SoLuong1,count( DISTINCT IDKhachHang) AS SoLuong2, SUM(TienTruocThue)SoTien
FROM PHIEUXUATKHO 
WHERE CONVERT(Datetime,Convert(Nvarchar,NGAYTHANG,103),103) BETWEEN @TuNgay AND @DenNgay 
AND IDKhachHang IN (SELECT IDKhachHang FROM @tbKHTheoThang WHERE [@tbKHTheoThang].KHMoi=1 AND [@tbKHTheoThang].Loai=N'XK'
				AND [@tbKHTheoThang].IDTakeCare=PHIEUXUATKHO.IDTakeCare AND
				 [@tbKHTheoThang].Thang =DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)) )
GROUP BY IDTakeCare,DATEADD(d,-1,DATEADD(mm, DATEDIFF(m,0,NGAYTHANG)+1,0)))tbSoXKMoi ON tbSoXKMoi.IDTakecare=NHANSU.ID

WHERE ID IN ({@IdNhanVien})
ORDER BY NHANSU.ID,STT,IDTieuChi,Ngay


SELECT * FROM @tbtmp
UNION all
SELECT -1 AS ID,NULL AS Ten, 99 AS IDDepatment,99 as STT, IDTieuChi,NoiDung,
(CASE [@tbTieuChi].IDTieuChi
	WHEN 1 THEN
		(SELECT convert(nvarchar, SUM(SoLuong1)) FROM @tbtmp WHERE [@tbtmp].IDTieuChi=[@tbTieuChi].IDTieuChi AND [@tbtmp].Ngay=tbNgay.Ngay)
	ELSE
        (SELECT ltrim( SUM(SoLuong1)) + '/' +  ltrim(Sum(SoLuong2)) FROM @tbtmp WHERE [@tbtmp].IDTieuChi=[@tbTieuChi].IDTieuChi AND [@tbtmp].Ngay=tbNgay.Ngay)
	END) SoLuong,
(SELECT SUM(SoLuong1) FROM @tbtmp WHERE [@tbtmp].IDTieuChi=[@tbTieuChi].IDTieuChi AND [@tbtmp].Ngay=tbNgay.Ngay) AS SoLuong1,
(SELECT SUM(SoLuong2) FROM @tbtmp WHERE [@tbtmp].IDTieuChi=[@tbTieuChi].IDTieuChi AND [@tbtmp].Ngay=tbNgay.Ngay) AS SoLuong2,
(SELECT SUM(SoTien) FROM @tbtmp WHERE [@tbtmp].IDTieuChi=[@tbTieuChi].IDTieuChi AND [@tbtmp].Ngay=tbNgay.Ngay) AS SoTien,
tbNgay.Ngay

FROM @tbTieuChi
CROSS JOIN (SELECT DISTINCT Ngay FROM @tbtmp WHERE [@tbtmp].Ngay IS NOT NULL) AS tbNgay