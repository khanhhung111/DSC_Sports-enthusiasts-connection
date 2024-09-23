import React from 'react';
import HeaderLogin from '../../components/Header/HearderLogin';
import HeroSection from './HeroSection';
import ProfileInforSection from './ProfileInforSection';
import Footer from '../../components/Footer/Footer';
import styles from './ProfileInforSection.module.css';

function Profile() {
  return (
    <div className={styles.accountPage}>
      <HeaderLogin />
      <main>
        <HeroSection />
        <ProfileInforSection />
      </main>
      <Footer />
    </div>
  );
}

export default Profile;