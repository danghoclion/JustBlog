﻿// <auto-generated />
using System;
using FA.JustBlog.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(JustBlogContext))]
    [Migration("20230303071550_AddCmt")]
    partial class AddCmt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Football",
                            Description = "Thong tin Football",
                            UrlSlug = "Football"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Basketball",
                            Description = "Thong tin Basketball",
                            UrlSlug = "Basketball"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Esports",
                            Description = "Thong tin Esports",
                            UrlSlug = "Esports"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.Property<int>("CmtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CmtID"), 1L, 1);

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConmmentHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("CmtID");

                    b.HasIndex("PostId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Published")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RateCount")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TotalRate")
                        .HasColumnType("int");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            CategoryId = 1,
                            Modified = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5604),
                            PostContent = "Giải vô địch quốc gia Việt Nam (V.League) là giải đấu cao nhất trong hệ thống bóng đá Việt Nam. Hiện đang được điều hành bởi Công ty Cổ phần bóng đá chuyên nghiệp Việt Nam (VPF).\r\n\r\nGiải đấu ra đời vào năm 1980 với tên gọi là giải bóng đá A1 toàn quốc, nhà vô địch đầu tiên của giải vô địch quốc gia là Đội bóng Tổng Cục Đường Sắt. Đến năm 1990, giải A1 toàn quốc được đổi tên thành giải các đội mạnh toàn quốc. Năm 1996, giải tiếp tục được đổi tên thành giải hạng Nhất quốc gia.\r\n\r\nV.League là giải gì 1\r\nLogo của V.League 1\r\nRiêng năm 1999, Giải bóng đá tập huấn mùa xuân thay thế cho giải vô địch quốc gia và không được công nhận là giải vô địch quốc gia. Đến mùa giải 2000-01, giải vô địch quốc gia chuyên nghiệp ra đời với tên gọi là V.League như ngày nay. Vào năm 2012, VPF thay thế LĐBĐ Việt Nam (VFF) điều hành giải đấu.\r\n\r\nV.League ngày nay có 14 đội tham dự, đội vô địch sẽ giành suất tham dự AFC Champions League. Theo thể thức hiện nay, đội cuối bảng sẽ xuống giải hạng nhất quốc gia, còn đội đứng áp chót sẽ thi đấu trận play-off tranh suất cuối cùng dự V.League mùa giải tiếp theo.\r\n\r\nLịch sử hình thành và phát triển của V.League\r\nGiải vô địch bóng đá A1 toàn quốc đầu tiên được tổ chức vào năm 1980 với sự tham gia của 17 đội được chia thành 3 khu vực. Đội đầu bảng ở mỗi khu vực sẽ giành quyền thi đấu vòng chung kết để xác định nhà vô địch của mùa giải. Tổng Cục Đường Sắt đánh bại Công An Hà Nội và Hải Quan để giành chức vô địch quốc gia đầu tiên trong lịch sử.\r\n\r\nThể thức chia khu vực diễn ra cho đến năm 1995 và được thay đổi sang thể thức đá vòng tròn chia 2 lượt đi và về như ngày nay. Riêng mùa giải 1996, sau khi thi đấu theo thể thức vòng tròn 2 lượt đi và về, 6 đội đầu bảng đá vòng tròn 1 lượt tranh chức vô địch, 6 đội cuối bảng sẽ thi đấu theo thể thức tương tự để chọn 2 đội xuống hạng.\r\n\r\nV.League là giải gì 2\r\n\r\nTừ năm 1997 đến nay, thể thức đá vòng tròn lượt đi và về được áp dụng. Tùy vào số đội tham dự mà có mùa giải sẽ có 1 đội xuống hạng, ngoài ra có thể là 2-3 đội xuống hạng sau khi mùa giải kết thúc.\r\n\r\nNăm 2000, giải vô địch quốc gia bắt đầu hoạt động theo mô hình chuyên nghiệp và được đổi tên thành V.League. Đến năm 2012, sau hàng loạt những cáo buộc liên quan đến công tác trọng tài, 6 đội bóng gồm Đồng Tâm Long An, Hoàng Anh Gia Lai, Hà Nội ACB, Vissai Ninh Bình, Khatoco Khánh Hòa and Lam Sơn Thanh Hóa dọa sẽ bỏ giải để thành lập giải đấu mới cho mùa giải 2012. Chủ tịch CLB Hà Nội ACB lúc bấy giờ là Nguyễn Đức Kiên là người có phản ứng quyết liệt nhất.\r\n\r\n\r\nSau cuộc họp vào ngày 29/9/2011, đại diện của VFF, các CLB tại V.League và giải hạng Nhất đã thống nhất về việc xin cấp phép hoạt động cho VPF. VFF được nắm giữ 36% cổ phần và số phần trăm còn lại chia đều cho các CLB tham gia giải đấu.\r\n\r\nV.League là giải gì 3\r\n\r\nNăm 2012, khi VPF điều hành giải đấu, V.League ban đầu được đổi tên thành Super Liga. Tuy nhiên tên gọi này không tồn tại được lâu trước sự phản đối quyết liệt từ VFF và Tổng cục Thể dục Thể thao. Sau đó giải được đổi tên là V.League 1 và giải hạng Nhất được đổi tên là V.League 2.\r\n\r\nThể thức của V.League\r\nMỗi mùa giải tại V.League khởi tranh từ tháng 2, 3 và kết thúc mùa giải vào tháng 10, 11. Các đội bóng sẽ thi đấu vòng tròn 2 lượt đi và về, mỗi đội sẽ thi đấu tổng cộng 26 trận.\r\n\r\nĐội vô địch sẽ giành vé tham dự AFC Champions League, trong khi đó đội cuối bảng xuống chơi ở giải hạng Nhất mùa giải tiếp theo. Đội đứng áp chót sẽ đá trận play-off với đội nhì bảng giải hạng Nhất để xác định suất cuối cùng tham dự V.League mùa giải tiếp theo.\r\n\r\n\r\nTiêu chí xếp hạng theo thứ tự nếu có 2 hoặc nhiều đội có cùng điểm:\r\n\r\nKết quả đối đầu trực tiếp.\r\nHiệu số bàn thắng bàn thua.\r\nTổng số bàn thắng.\r\nV.League là giải gì 4\r\nHà Nội FC là đội bóng giàu thành tích nhất lịch sử V.League\r\nĐội bóng nào giàu thành tích nhất V.League?\r\nVề tổng số danh hiệu vô địch, Hà Nội FC và Thể Công đang là 2 đội bóng giàu thành tích nhất lịch sử V.League khi mỗi đội có cùng 5 danh hiệu vô địch. Nếu xét tổng thể về bảng xếp hạng huy chương, Hà Nội (4) có nhiều lần giành ngôi á quân hơn so với Thể Công (3).\r\n\r\nBecamex Bình Dương và Cảng Sài Gòn xếp sau khi mỗi đội có 4 lần vô địch V.League. Sông Lam Nghệ An và SHB Đà Nẵng cũng có 3 lần vô địch. HAGL, Đồng Tâm Long An và Đồng Tháp có 2 lần giành chức vô địch.\r\n\r\n\r\nCác đội bóng còn lại có ít nhất 1 lần nâng cao cúp vô địch V.League là Hải Quan, Nam Định, Công An Hà Nội, Tổng Cục Đường Sắt, Công An TPHCM, Quảng Nam.\r\n\r\nTrên đây là những thông tin về V.League là giải gì? Đội bóng nào giàu thành tích nhất V.League? Những bài viết khác trong chuyên mục Bóng đá Việt Nam sẽ có tại Blogsoccer.net.",
                            PostedOn = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5590),
                            Published = "1",
                            RateCount = 0,
                            ShortDescription = "V.League là giải gì?",
                            Title = "V.League là giải gì? Đội bóng nào giàu thành tích nhất V.League?",
                            TotalRate = 0,
                            UrlSlug = "/thoisu",
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 2,
                            CategoryId = 2,
                            Modified = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5608),
                            PostContent = "TTO - Từ giờ cho đến cuối năm 2022, một loạt giải bóng rổ nhà nghề cũng như vòng loại giải đẳng cấp thế giới sẽ được tổ chức, trong đó có nhiều giải hấp dẫn từng bị gián đoạn do ảnh hưởng của COVID-19.\r\nGiải nhà nghề Đông Nam Á sẽ trở lại\r\n\r\nABL (ASEAN Basketball League) là giải bóng rổ nhà nghề Đông Nam Á được thành lập từ năm 2009 và đã bị ngắt quãng hai năm do dịch COVID-19.\r\n\r\nNhiều giải bóng rổ hấp dẫn sắp khởi tranh - Ảnh 1.\r\nAds (0:00)\r\nTuyển Việt Nam tham dự ABL 3x3 2022 tại Bali - Ảnh: VBF\r\n\r\nĐầu năm nay, ABL đã khởi động trở lại với hai sự kiện nhỏ là giải bóng rổ 3x3 (ABL 3x3 International Champions Cup 2022) và giải bóng rổ 5x5 chuẩn bị cho SEA Games 31 (ABL Pre-SEA Games Challenge 2022).\r\n\r\nĐây là hai giải đấu mà Đội tuyển Việt Nam đều góp mặt. Trong đó, tuyển nữ đã làm nên lịch sử khi giành huy chương vàng ở giải bóng rổ 3x3. Với thành công của hai giải đã diễn ra vào đầu năm, ABL được kỳ vọng sẽ trở lại đúng lịch vào tháng 9.\r\n\r\nNgoài ABL, những tháng còn lại của năm 2022 cũng sẽ nhộn nhịp với các giải đấu và vòng loại đẳng cấp châu lục. Đặc biệt, vòng sơ loại đầu tiên của giải FIBA Asia Cup 2025 (FIBA Asia Cup 2025 Pre-Qualifiers First Round) sẽ rất thu hút bởi có sự góp mặt của đội tuyển Việt Nam.\r\n\r\nGiải đấu này dự kiến diễn ra vào tháng 11 và đội tuyển nam Việt Nam sẽ cùng chung bảng với hai đại diện Đông Nam Á quen thuộc khác là Thái Lan và Malaysia.\r\n\r\nNhiều giải bóng rổ hấp dẫn sắp khởi tranh - Ảnh 2.\r\nTuyển Việt Nam chung bảng D với Thái Lan, Malaysia và Mông Cổ tại vòng loại FIBA Asia Cup 2025 - Ành: VBA\r\n\r\nNgoài ra, cuối tháng 9 (từ 26-9 đến 1-10) cũng sẽ diễn ra giải FIBA Asia Champions Cup 2022. Đây là giải đấu hấp dẫn do liên đoàn bóng rổ quốc tế (FIBA) tổ chức dành riêng cho khu vực châu Á.\r\n\r\nGiải quy tụ 8 đội tranh tài, trong đó sẽ có 4 CLB là nhà vô địch tại các giải nhà nghề của các cường quốc bóng rổ châu Á gồm Trung Quốc, Nhật Bản, Hàn Quốc, Philippines và bốn đội còn lại được xác định qua vòng sơ loại.\r\n\r\nSao VBA tề tựu về Hà Nội\r\n\r\nỞ đấu trường trong nước, vào tháng 11 cũng sẽ diễn ra Đại hội Thể dục Thể thao toàn quốc 2022 (tổ chức 4 năm/lần). Sự kiện thể thao đáng mong chờ nhất trong năm nay sẽ diễn ra tại Quảng Ninh và một số tỉnh khác với 40 bộ môn thi đấu, trong đó có bóng rổ.\r\n\r\nNgoài ra, ngay trong cuối tháng 9, Giải bóng rổ vô địch Hà Nội (Hanoi Basketball Championship 2022) cũng khởi tranh. Sân chơi này quy tụ 13 đội bóng tranh tổng giải thưởng giá trị lên đến hơn 150 triệu đồng.\r\n\r\nGiải phong trào mới mẻ của bóng rổ Hà Nội thu hút sự quan tâm bởi sự góp mặt của các ngôi sao VBA như Tâm Đinh, Nguyễn Văn Hùng, Tô Quang Trung, Huỳnh Thanh Tâm, ngoại binh DeAngelo Hamilton, Dominique Grant,..\r\n\r\nNhiều giải bóng rổ hấp dẫn sắp khởi tranh - Ảnh 3.\r\nHọp báo công bố tổ chức Hanoi Basketball Championship 2022 - Ảnh: VBA\r\n\r\nNgoài ra, sự có mặt của bộ ba anh em \"thần tượng\" của bóng rổ Hà Nội là Hoàng \"Ca\" (Nguyễn Phú Hoàng), Đạt \"Doc\" (Nguyễn Thành Đạt) và Hưng \"James\" (Nguyễn Thịnh Hưng) cũng là điểm nhấn, tăng thêm độ nóng cho giải.\r\n\r\nHBC 2022 đã có lịch thi đấu chính thức từ ngày 21-9 đến 2-10 tại Nhà thi đấu huyện Thanh Trì (Hà Nội).",
                            PostedOn = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5607),
                            Published = "0",
                            RateCount = 0,
                            ShortDescription = "Giải nhà nghề Đông Nam Á sẽ trở lại",
                            Title = "Nhiều giải bóng rổ hấp dẫn sắp khởi tranh",
                            TotalRate = 0,
                            UrlSlug = "/tinnong",
                            ViewCount = 0
                        },
                        new
                        {
                            PostId = 3,
                            CategoryId = 3,
                            Modified = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5610),
                            PostContent = "Khi các đội chơi xuất sắc nhất từ khắp nơi trên thế giới đang khấp khởi chuẩn bị cho các trận chiến nảy lửa tại PCS7, chúng tôi muốn cung cấp thêm một ít thông tin chi tiết hơn về giải đấu lớn nhất trong năm, PGC 2022.\r\n\r\nHãy đọc tiếp để biết thêm thông tin về giải đấu này nhé.\r\n\r\nGIẢI ĐẤU PGC 2022\r\n\r\nPUBG GLOBAL CHAMPIONSHIP 2022 (PGC 2022) sẽ là một giải đấu Offline (LAN), với sự tham dự của tổng cộng 32 đội và hơn 128 người chơi đang háo hức quay trở lại đấu trường.\r\n\r\nTHỂ THỨC GIẢI ĐẤU\r\n\r\nHành trình của giải đấu sẽ bắt đầu vào ngày 01/11 với các trận đấu Vòng Bảng và kết thúc bằng Chung Kết Tổng (Grand Final) bắt đầu vào ngày 18/11. \r\n\r\nTUẦN 1 – VÒNG BẢNG\r\n\r\nTuần đầu tiên của PGC 2022 sẽ bắt đầu với Vòng bảng, các đội sẽ chiến đấu với nhau để giành một suất vào Chung Kết Tổng (Grand Final).\r\n\r\nTrước các trận đấu của Vòng Bảng, 32 đội sẽ được chia thành HAI bảng: Bảng A & Bảng B.\r\nMỗi bảng sẽ thi đấu trong 3 ngày, mỗi ngày 5 trận đấu. Tổng cộng mỗi bảng sẽ thi đấu 15 trận.\r\nDựa trên kết quả của Vòng Bảng,\r\n8 đội có thứ hạng cao nhất của mỗi bảng sẽ được xếp vào Nhánh Thắng\r\n8 đội đứng cuối bảng của mỗi bảng sẽ được xếp vào Nhánh Thua.\r\nTUẦN 2 – NHÁNH THẮNG/NHÁNH THUA\r\n\r\nTuần thứ hai của PGC 2022 sẽ gồm các trận so tài giữa Nhánh Thắng và Nhánh Thua.\r\n\r\nNHÁNH THẮNG\r\nNHÁNH THẮNG sẽ gồm có 8 đội đứng đầu Bảng A và 8 đội đứng đầu Bảng B.\r\nNHÁNH THẮNG sẽ có 10 trận đấu được tổ chức trong 2 ngày (mỗi ngày 5 trận).\r\nPhần thưởng dành cho các đội chiến thắng ở NHÁNH THẮNG sẽ vô cùng giá trị.\r\n8 đội đứng đầu trong NHÁNH THẮNG sẽ được giành suất vào thẳng CHUNG KẾT TỔNG (GRAND FINAL).\r\n8 đội còn lại từ hạng 9 -> 16 sẽ được xếp vào NHÁNH THUA 2 tiếp sau đó để có thêm một cơ hội khác. \r\nNHÁNH THUA 1\r\nNHÁNH THUA 1 sẽ gồm có 8 đội đứng cuối Bảng A và 8 đội đứng cuối Bảng B.\r\n16 đội này sẽ thi đấu 10 trận đấu trong 2 ngày (mỗi ngày 5 trận).\r\n8 đội có thứ hạng cao nhất sau 10 trận đấu ở NHÁNH THUA 1 sẽ lọt vào NHÁNH THUA 2.\r\nĐội xếp hạng 9 -> 15 sẽ được phải tham gia SINH TỒN TUYỆT ĐỈNH, và đội xếp hạng chót (hạng 16) ở NHÁNH THUA 1 sẽ bị loại.\r\nNHÁNH THUA 2\r\nNHÁNH THUA 2 có 10 trận đấu diễn ra trong 2 ngày (mỗi ngày 5 trận).\r\nChỉ 4 đội đứng đầu mới giành được vé tiến vào CHUNG KẾT TỔNG (GRAND FINAL).\r\n12 đội còn lại từ hạng 5 -> 16 sẽ tiếp tục tham gia vào SINH TỒN TUYỆT ĐỈNH. \r\nTUẦN 3 – CHUNG KẾT TỔNG (GRAND FINAL) VÀ SINH TỒN TUYỆT ĐỈNH (GRAND SURVIVAL)\r\n\r\nSINH TỒN TUYỆT ĐỈNH\r\nTuần cuối cùng của PGC 2022 sẽ bắt đầu tại SINH TỒN TUYỆT ĐỈNH với tổng số 19 đội tham gia.\r\n\r\n12 đội đến từ NHÁNH THUA 2.\r\n7 đội đến từ NHÁNH THUA 1.\r\n3 đội đứng cuối từ NHÁNH THUA 1 sẽ được đưa vào danh sách chờ.\r\nSINH TỒN TUYỆT ĐỈNH sẽ chỉ cung cấp 4 cơ hội cuối cùng tham gia CHUNG KẾT TỔNG (GRAND FINAL), nơi 16 đội chơi sẽ chiến đấu để trở thành đội cuối cùng sống sót. Trong mỗi trận đấu, đội giành được Chicken Dinner sẽ tiến vào Chung Kết Tổng (GRAND FINAL) và 15 đội còn lại tham gia cùng với đội chơi tiếp theo trong danh sách. \r\n\r\nCHUNG KẾT TỔNG (GRAND FINAL)\r\nSau khi giờ nghỉ giải lao ngắn ngủi sau Sinh Tồn Tuyệt Đỉnh, các chiến binh lão luyện sẽ phải vượt qua giới hạn của chính mình trong thử thách cuối cùng để đăng quang PGC.\r\n\r\nChung Kết Tổng (Grand Final) sẽ diễn ra trong 4 ngày, với 5 trận đấu mỗi ngày. Tổng cộng 20 trận.\r\nĐội tuyển nào giành vị trí cao nhất sẽ là quán quân mới của GIẢI VÔ ĐỊCH PUBG THẾ GIỚI. (PUBG GLOBAL CHAMPIONSHIP)\r\nQUỸ GIẢI THƯỞNG \r\n\r\nTổng quỹ giải thưởng của PGC 2022 bắt đầu với 2 triệu USD, sẽ được chia cho các đội chơi tham dự theo kết quả cuối cùng của giải đấu.\r\n\r\nThứ hạng cuối cùng sẽ được quyết định dựa trên các vị trí cuối cùng ở Chung Kết Tổng (Grand Final).\r\nGIẢI THƯỞNG ĐẶC BIỆT\r\nNgười chơi MVP của giải đấu sẽ được nhận thêm một giải thưởng trị giá 10,000 USD.\r\nLỢI NHUẬN BÁN VẬT PHẨM PGC 2022\r\nTất cả các đội chơi tham gia sẽ được hưởng từ 30% lợi nhuận thu được từ việc bán các vật phẩm trong cửa hàng PGC 2022. Lợi nhuận sẽ được chia cho các đội chơi dựa theo thứ hạng giải đấu cuối cùng của họ. Các thông tin khác về các vật phẩm PGC 2022 sẽ được chúng tôi gửi tới ở các thông báo tiếp theo.\r\n\r\nThêm nhiều tin tức khác của PGC 2022 sẽ sớm được công bố ngay sau PCS7.\r\n\r\nCho đến lúc đó, để biết thông tin mới nhất về PUBG Esports, hãy truy cập pubgesports.com, và đừng quên theo dõi @pubgesports trên mạng xã hội nhé.",
                            PostedOn = new DateTime(2023, 3, 3, 14, 15, 49, 800, DateTimeKind.Local).AddTicks(5609),
                            Published = "1",
                            RateCount = 0,
                            ShortDescription = "Xin chào, những người bạn đam mê PUBG Esports!",
                            Title = "CÔNG BỐ THỂ THỨC GIẢI ĐẤU PGC 2022",
                            TotalRate = 0,
                            UrlSlug = "/xahoi",
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTagMaps", (string)null);

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 1
                        },
                        new
                        {
                            PostId = 1,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags", (string)null);

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Count = 1,
                            Description = "Van de thoi su",
                            TagName = "New",
                            UrlSlug = "/thoisu"
                        },
                        new
                        {
                            TagId = 2,
                            Count = 1,
                            Description = "Van de tin tuc",
                            TagName = "LOL",
                            UrlSlug = "/tinnong"
                        },
                        new
                        {
                            TagId = 3,
                            Count = 1,
                            Description = "Van de xa hoi",
                            TagName = "HasTag",
                            UrlSlug = "/xahoi"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FA.JustBlog.Core.Data.BlogUsers", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("BlogUsers");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comment", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTagMap", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tag", "Tag")
                        .WithMany("PostTagMaps")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostTagMaps");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Navigation("PostTagMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
