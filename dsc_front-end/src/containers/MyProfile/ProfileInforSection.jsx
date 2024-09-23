import React from 'react';
import ProfileInforCard from './ProfileInforCard';
import styles from './ProfileInforSection.module.css';

function ProfileInforSection() {
  const accountInfo = [
    { title: 'Tên', value: 'Hung' },
    { title: 'Địa chỉ', value: 'N/A' },
    { title: 'Giới tính', value: 'N/A' },
    { title: 'Tuổi', value: 'N/A' },
    { title: 'Chiều cao', value: '178 cm' },
    { title: 'Cân nặng', value: '70 kg' },
  ];

  return (
    <section className={styles.accountInfoSection}>
      <h2 className={styles.sectionTitle}>Tài khoản</h2>
      <p className={styles.sectionDescription}>
        Express yourself! Let others in the community get to know you.
      </p>
      <div className={styles.cardGrid}>
        {accountInfo.map((info, index) => (
          <ProfileInforCard key={index} title={info.title} value={info.value} />
        ))}
      </div>
    </section>
  );
}

export default ProfileInforSection;