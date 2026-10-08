// يمكنكِ إضافة تفاعلات الجافاسكربت هنا
document.addEventListener('DOMContentLoaded', () => {
    const bookBtn = document.querySelector('.btn-outline');
    const allBtn = document.querySelector('.btn-text');

    bookBtn.addEventListener('click', (e) => {
        e.preventDefault();
        alert('Navigating to Book Appointment page...');
    });

    allBtn.addEventListener('click', (e) => {
        e.preventDefault();
        alert('Navigating to All Appointments page...');
    });
});