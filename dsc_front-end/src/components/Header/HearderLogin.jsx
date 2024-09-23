import React from 'react';
import styles from './HeaderLogin.module.css';

function HeaderLogin() {
  const navItems = [
    { label: 'Kèo hàng ngày', href: '#' },
    { label: 'Giải đấu', href: '#' },
    { label: 'Câu lạc bộ', href: '#' },
    { label: 'Thông báo', href: '#' },
  ];

  return (
    <header className={styles.header}>
      <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/d49291d2c7f0206b44d14e01258fdaeccb10182cc5eb928d0344d1ccfa220d40?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="" className={styles.logoIcon} />
      <div className={styles.logoContainer}>
        <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/2bd87701f8e5de31409290c62870400ced251ecd3f5895c6c336318f1e3231eb?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="DSC Logo" className={styles.dscLogo} />
        <span className={styles.dscText}>DSC</span>
      </div>
      <span className={styles.userName}>Hưng</span>
      <form className={styles.searchForm} role="search">
        <label htmlFor="searchInput" className={styles.visuallyHidden}>Tìm kiếm</label>
        <input type="search" id="searchInput" className={styles.searchInput} placeholder="Tìm kiếm" />
        <button type="submit" className={styles.searchButton}>
          <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/5f7d9769fc259cc831aca284961ced9f9831287ba1d8f135e3e13059e913ff23?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="Search" className={styles.searchIcon} />
        </button>
      </form>
      <nav>
        <ul className={styles.navList}>
          {navItems.map((item, index) => (
            <li key={index}>
              <a href={item.href} className={styles.navItem}>{item.label}</a>
            </li>
          ))}
        </ul>
      </nav>
    </header>
  );
}

export default HeaderLogin;