import React from 'react';
import styles from './HeroSection.module.css';

function HeroSection() {
  return (
    <section className={styles.heroSection}>
      <h1 className={styles.heroTitle}>Update your password and secure your account</h1>
      <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/d8dd3fc5687479409e7740c79f01840fd5aa4238a0213f97babca706bff5fa78?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="Security illustration" className={styles.heroImage} />
      <div className={styles.userInfo}>
        <hr className={styles.divider} />
        <p className={styles.userName}>Tên: Hung</p>
      </div>
      <button className={styles.logoutButton}>Đăng xuất</button>
    </section>
  );
}

export default HeroSection;